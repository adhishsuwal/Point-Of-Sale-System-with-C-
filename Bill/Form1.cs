using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.IO;

namespace POSSystem
{
    public partial class Form1 : Form
    {
        Serialize serial = new Serialize();

        private bool status = false;
        private int row = 0;
        List<Panel> listPanel = new List<Panel>(); //ArrayList for panel
        int index; //defining index value in form1_load
        private List<string> categoryArray = new List<string>();
        private List<int> priceArray = new List<int>();

        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        //method to add the data to show in datagridview1
        private void addbutton_Click(object sender, EventArgs e)
        {
            serial.item = textBox1.Text;
            serial.category = comboBox1.Text;
            serial.price = textBox2.Text;

            String item = serial.item;
            String category = serial.category;
            String price = serial.price;

            //method to perform validation and adding items
            if (this.status)
            {

                menudataGridView1.Rows[this.row].Cells[0].Value = item;
                menudataGridView1.Rows[this.row].Cells[1].Value = category;
                menudataGridView1.Rows[this.row].Cells[2].Value = price;
                this.addbutton.Text = "Add";
                menudataGridView1.Rows[this.row].Selected = true;

                MessageBox.Show("Record has been updated.");
            }
            else if (item != "" && item.Length > 0 && price != "" && price.Length > 0 && category != "")
            {
                int count = menudataGridView1.Rows.Count - 1;
                menudataGridView1.Rows.Add();
                menudataGridView1.Rows[count].Cells[0].Value = item;
                menudataGridView1.Rows[count].Cells[1].Value = category;
                menudataGridView1.Rows[count].Cells[2].Value = price;
                menudataGridView1.Rows[count].Selected = true;

                MessageBox.Show("Record has been saved.");
            }
            else
            {
                MessageBox.Show("Please enter values.");
            }
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            this.status = false;
            this.row = 0;
        }

        //method for the functionality of clear button to clear textboxes
        private void clear1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        //method to clear
        private void ClearTextBoxes(Control.ControlCollection controlCollection)
        {
            foreach (Control ctrl in controlCollection)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }

        //method to select content to edit and update by double-clicking on the datagrid cell
        private void menudataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String item = Convert.ToString(menudataGridView1.Rows[e.RowIndex].Cells[0].Value);
            String category = Convert.ToString(menudataGridView1.Rows[e.RowIndex].Cells[1].Value);
            String price = Convert.ToString(menudataGridView1.Rows[e.RowIndex].Cells[2].Value);

            if (item != "" && item.Length > 0 && category != "" && price != "" && price.Length > 0)
            {
                this.row = e.RowIndex;
                this.status = true;
                textBox1.Text = item;
                comboBox1.Text = category;
                textBox2.Text = price;

                this.addbutton.Text = "Update";
            }
        }

        //method to clear all the row in menu datagridview
        private void clear2_Click(object sender, EventArgs e)
        {
            menudataGridView1.Rows.Clear();
        }

        //method to delete certain rows in the sales datagridview
        private void delbutton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.salesdataGridView2.SelectedRows)
                {
                    salesdataGridView2.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method for the functionality of import button
        private void importbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            //To list only csv files, we need to add this filter
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files (*.*) | *.*";

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox4.Text = dialog.FileName;
                string val = textBox4.Text;
                importCSVFile(val);
            }
        }

        //method to import a file in datagridview
        private void importCSVFile(string filepath)
        {
            try
            {
                //using Microsoft.VisualBasic, FileIO;
                TextFieldParser csvreader = new TextFieldParser(filepath);

                //set delimiter for the reader to specific value(,)
                csvreader.SetDelimiters(new String[] { "," });

                csvreader.HasFieldsEnclosedInQuotes = true;

                csvreader.ReadFields();

                //Denotes if fields are enclose in quotation marks
                //csvreader.HasFieldEnclosedInQuotes = true;

                while (!csvreader.EndOfData)
                {
                    string[] fieldData = csvreader.ReadFields(); //read all fields of current line
                    //dataGridView1.Rows.Add();

                    for (int i = 0; i < fieldData.Length; i++)
                    {
                        menudataGridView1.Rows.Add(fieldData);
                        //dataGridView1.Rows[j].Cells[i].Value = fieldData[i];
                        break;
                    }
                    //Console.WriteLine("");
                    //j += 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method to calculate the total amount
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < salesdataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(salesdataGridView2.Rows[i].Cells[2].Value);
            }
            MessageBox.Show("Total Amount = " + (sum.ToString()));
        }

        //switching to panel
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(firstpanel);
            listPanel.Add(secondpanel);
            listPanel[index].BringToFront();

            this.menudataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.menudataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.menudataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            this.salesdataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //method to clear datagridview2
        private void clear3_Click(object sender, EventArgs e)
        {
            salesdataGridView2.DataSource = null;
        }

        //method to switch to menu panel
        private void viewMenu_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        //method to switch to sales panel          
        private void viewSales_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        //method for functionality of the button that generates the chart
        private void chartbutton_Click(object sender, EventArgs e)
        {
            sales.Series["Sales"].Points.Clear();
            categoryArray.Clear();
            priceArray.Clear();

            totalCategoryItem();
            generateChart(); //method called for chart

            label4.Text = "Sales Chart"; //show the desired text after button click
        }

        // method to select item name, price and category
        private void totalCategoryItem()
        {
            for (int i = 0; i < salesdataGridView2.Rows.Count - 1; i++)
            {
                string firCategory = Convert.ToString(salesdataGridView2.Rows[i].Cells[1].Value);
                int firPrice = Convert.ToInt16(salesdataGridView2.Rows[i].Cells[2].Value);

                if (i == 0)
                {
                    int totalCatItem = firPrice;
                    for (int j = 1; j < salesdataGridView2.Rows.Count - 1; j++)
                    {
                        string secCategory = Convert.ToString(salesdataGridView2.Rows[j].Cells[1].Value);
                        int secPrice = Convert.ToInt16(salesdataGridView2.Rows[j].Cells[2].Value);
                        if (firCategory == secCategory)
                        {
                            totalCatItem += secPrice;
                        }
                    }
                    this.priceArray.Add(totalCatItem);
                    this.categoryArray.Add(firCategory);
                }
                else if (!this.categoryArray.Contains(firCategory))
                {
                    int totalCatItem = firPrice;
                    for (int j = i + 1; j < salesdataGridView2.Rows.Count - 1; j++)
                    {
                        string secCategory = Convert.ToString(salesdataGridView2.Rows[j].Cells[1].Value);
                        int secPrice = Convert.ToInt16(salesdataGridView2.Rows[j].Cells[2].Value);
                        if (firCategory == secCategory)
                        {
                            totalCatItem += secPrice;
                        }
                    }
                    this.priceArray.Add(totalCatItem);
                    this.categoryArray.Add(firCategory);
                }
            }
        }

        // method to generate chart
        private void generateChart()
        {
            for (int i = 0; i < this.categoryArray.Count; i++)
            {
                sales.Series["Sales"].Points.Add(this.priceArray[i]);
                sales.Series["Sales"].Points[i].LegendText = this.categoryArray[i];
                this.sales.Series["Sales"].Points[i].Label = "#LEGENDTEXT " + this.priceArray[i].ToString();
            }
        }

        //method to validate string value in item textbox; not integer
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //method to validate integer value in price textbox; not string
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //method to sort by price
        private void sortprice_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menudataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < menudataGridView1.Rows.Count - 1; j++)
                {
                    DataGridViewRow row1 = menudataGridView1.Rows[j];
                    DataGridViewRow row2 = menudataGridView1.Rows[j - 1];
                    int price_1 = Convert.ToInt16(row1.Cells[2].Value);
                    int price_2 = Convert.ToInt16(row2.Cells[2].Value);

                    if (price_1 < price_2)
                    {
                        menudataGridView1.Rows.Remove(row1);
                        menudataGridView1.Rows.Remove(row2);
                        menudataGridView1.Rows.Insert(j - 1, row1);
                        menudataGridView1.Rows.Insert(j, row2);
                    }
                }
            }
        }

        //method to sort by item
        private void sortitem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menudataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < menudataGridView1.Rows.Count - 1; j++)
                {
                    DataGridViewRow row1 = menudataGridView1.Rows[j];
                    DataGridViewRow row2 = menudataGridView1.Rows[j - 1];
                    string item_1 = Convert.ToString(row1.Cells[0].Value);
                    string item_2 = Convert.ToString(row2.Cells[0].Value);

                    if (string.Compare(item_1, item_2) < 0)
                    {
                        menudataGridView1.Rows.Remove(row1);
                        menudataGridView1.Rows.Remove(row2);
                        menudataGridView1.Rows.Insert(j - 1, row1);
                        menudataGridView1.Rows.Insert(j, row2);
                    }
                }
            }
        }

        //method for enabling hover effect on buttons for panel1
        private void panel1EButtons_MouseEnter(object sender, EventArgs e)
        {
            Button color = (Button)sender;
            color.BackColor = Color.SlateBlue;
        }

        //method for disabling hover effect on buttons for panel1
        private void panel1LButtons_MouseLeave(object sender, EventArgs e)
        {
            Button color = (Button)sender;
            color.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
        }

        //method for enabling hover effect on button for panel2
        private void panel2EButtons_MouseEnter(object sender, EventArgs e)
        {
            Button color = (Button)sender;
            color.BackColor = Color.SlateBlue;
        }

        //method for disabling hover effect on buttons for panel2
        private void panel2LButtons_MouseLeave(object sender, EventArgs e)
        {
            Button color = (Button)sender;
            color.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
        }

        //method to close the system from the menu bar
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?", "Restaurant POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //method for showing details about developer
        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is developed by Adhish Suwal", "About Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //method to transfer selected items to another datagridview
        private void selectButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Category");
            dt.Columns.Add("Price");

            foreach (DataGridViewRow row in menudataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                }
            }
            salesdataGridView2.DataSource = null;
            salesdataGridView2.DataSource = dt;
        }
    }
}
