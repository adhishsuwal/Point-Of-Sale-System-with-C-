namespace POSSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.firstpanel = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.viewSales = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sortItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menudataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clear1 = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.importbutton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondpanel = new System.Windows.Forms.Panel();
            this.delButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clear3 = new System.Windows.Forms.Button();
            this.chartbutton = new System.Windows.Forms.Button();
            this.viewMenu = new System.Windows.Forms.Button();
            this.salesdataGridView2 = new System.Windows.Forms.DataGridView();
            this.sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.firstpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menudataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.secondpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            this.SuspendLayout();
            // 
            // firstpanel
            // 
            this.firstpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstpanel.Controls.Add(this.selectButton);
            this.firstpanel.Controls.Add(this.label5);
            this.firstpanel.Controls.Add(this.viewSales);
            this.firstpanel.Controls.Add(this.button5);
            this.firstpanel.Controls.Add(this.sortItem);
            this.firstpanel.Controls.Add(this.button2);
            this.firstpanel.Controls.Add(this.label3);
            this.firstpanel.Controls.Add(this.comboBox1);
            this.firstpanel.Controls.Add(this.textBox1);
            this.firstpanel.Controls.Add(this.label1);
            this.firstpanel.Controls.Add(this.menudataGridView1);
            this.firstpanel.Controls.Add(this.textBox2);
            this.firstpanel.Controls.Add(this.clear1);
            this.firstpanel.Controls.Add(this.addbutton);
            this.firstpanel.Controls.Add(this.label2);
            this.firstpanel.Controls.Add(this.importbutton);
            this.firstpanel.Controls.Add(this.textBox4);
            this.firstpanel.Controls.Add(this.menuStrip1);
            this.firstpanel.Location = new System.Drawing.Point(12, 0);
            this.firstpanel.Name = "firstpanel";
            this.firstpanel.Size = new System.Drawing.Size(796, 541);
            this.firstpanel.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectButton.ForeColor = System.Drawing.SystemColors.Info;
            this.selectButton.Location = new System.Drawing.Point(405, 463);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(97, 40);
            this.selectButton.TabIndex = 49;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Restaurant Point-Of-Sale System";
            // 
            // viewSales
            // 
            this.viewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSales.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewSales.ForeColor = System.Drawing.SystemColors.Info;
            this.viewSales.Location = new System.Drawing.Point(611, 463);
            this.viewSales.Name = "viewSales";
            this.viewSales.Size = new System.Drawing.Size(94, 38);
            this.viewSales.TabIndex = 46;
            this.viewSales.Text = "View Sales";
            this.viewSales.UseVisualStyleBackColor = false;
            this.viewSales.Click += new System.EventHandler(this.viewSales_Click);
            this.viewSales.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.viewSales.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.ForeColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(122, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 45;
            this.button5.Text = "Sort By Price";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.sortprice_Click);
            this.button5.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // sortItem
            // 
            this.sortItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sortItem.ForeColor = System.Drawing.SystemColors.Info;
            this.sortItem.Location = new System.Drawing.Point(12, 467);
            this.sortItem.Name = "sortItem";
            this.sortItem.Size = new System.Drawing.Size(104, 33);
            this.sortItem.TabIndex = 44;
            this.sortItem.Text = "Sort By Item";
            this.sortItem.UseVisualStyleBackColor = false;
            this.sortItem.Click += new System.EventHandler(this.sortitem_Click);
            this.sortItem.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.sortItem.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(508, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 42;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clear2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(381, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Snacks",
            "Dinner",
            "Drinks"});
            this.comboBox1.Location = new System.Drawing.Point(468, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(71, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Item:";
            // 
            // menudataGridView1
            // 
            this.menudataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menudataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.menudataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menudataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.checkBoxColumn});
            this.menudataGridView1.Location = new System.Drawing.Point(13, 177);
            this.menudataGridView1.Name = "menudataGridView1";
            this.menudataGridView1.RowTemplate.Height = 24;
            this.menudataGridView1.Size = new System.Drawing.Size(692, 278);
            this.menudataGridView1.TabIndex = 30;
            this.menudataGridView1.TabStop = false;
            this.menudataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menudataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "Select";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(71, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 31;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // clear1
            // 
            this.clear1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear1.ForeColor = System.Drawing.SystemColors.Info;
            this.clear1.Location = new System.Drawing.Point(587, 102);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(117, 36);
            this.clear1.TabIndex = 36;
            this.clear1.Text = "Clear Data";
            this.clear1.UseVisualStyleBackColor = false;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            this.clear1.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.clear1.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // addbutton
            // 
            this.addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.addbutton.Location = new System.Drawing.Point(465, 102);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(117, 36);
            this.addbutton.TabIndex = 35;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            this.addbutton.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.addbutton.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Price:";
            // 
            // importbutton
            // 
            this.importbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.importbutton.Location = new System.Drawing.Point(587, 139);
            this.importbutton.Name = "importbutton";
            this.importbutton.Size = new System.Drawing.Size(118, 32);
            this.importbutton.TabIndex = 34;
            this.importbutton.Text = "Import";
            this.importbutton.UseVisualStyleBackColor = false;
            this.importbutton.Click += new System.EventHandler(this.importbutton_Click);
            this.importbutton.MouseEnter += new System.EventHandler(this.panel1EButtons_MouseEnter);
            this.importbutton.MouseLeave += new System.EventHandler(this.panel1LButtons_MouseLeave);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(12, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(570, 22);
            this.textBox4.TabIndex = 33;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDeveloperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutDeveloperToolStripMenuItem.Image")));
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // secondpanel
            // 
            this.secondpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.secondpanel.Controls.Add(this.delButton);
            this.secondpanel.Controls.Add(this.calculateButton);
            this.secondpanel.Controls.Add(this.clear3);
            this.secondpanel.Controls.Add(this.chartbutton);
            this.secondpanel.Controls.Add(this.viewMenu);
            this.secondpanel.Controls.Add(this.salesdataGridView2);
            this.secondpanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.secondpanel.Location = new System.Drawing.Point(-8, 0);
            this.secondpanel.Name = "secondpanel";
            this.secondpanel.Size = new System.Drawing.Size(819, 538);
            this.secondpanel.TabIndex = 47;
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delButton.ForeColor = System.Drawing.SystemColors.Info;
            this.delButton.Location = new System.Drawing.Point(573, 463);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(90, 41);
            this.delButton.TabIndex = 44;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.Info;
            this.calculateButton.Location = new System.Drawing.Point(328, 463);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(117, 41);
            this.calculateButton.TabIndex = 33;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            this.calculateButton.MouseEnter += new System.EventHandler(this.panel2EButtons_MouseEnter);
            this.calculateButton.MouseLeave += new System.EventHandler(this.panel2LButtons_MouseLeave);
            // 
            // clear3
            // 
            this.clear3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear3.ForeColor = System.Drawing.SystemColors.Info;
            this.clear3.Location = new System.Drawing.Point(451, 464);
            this.clear3.Name = "clear3";
            this.clear3.Size = new System.Drawing.Size(117, 41);
            this.clear3.TabIndex = 32;
            this.clear3.Text = "Clear";
            this.clear3.UseVisualStyleBackColor = false;
            this.clear3.Click += new System.EventHandler(this.clear3_Click);
            this.clear3.MouseEnter += new System.EventHandler(this.panel2EButtons_MouseEnter);
            this.clear3.MouseLeave += new System.EventHandler(this.panel2LButtons_MouseLeave);
            // 
            // chartbutton
            // 
            this.chartbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chartbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chartbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.chartbutton.Location = new System.Drawing.Point(678, 404);
            this.chartbutton.Name = "chartbutton";
            this.chartbutton.Size = new System.Drawing.Size(117, 41);
            this.chartbutton.TabIndex = 31;
            this.chartbutton.Text = "Generate Chart";
            this.chartbutton.UseVisualStyleBackColor = false;
            this.chartbutton.Click += new System.EventHandler(this.chartbutton_Click);
            this.chartbutton.MouseEnter += new System.EventHandler(this.panel2EButtons_MouseEnter);
            this.chartbutton.MouseLeave += new System.EventHandler(this.panel2LButtons_MouseLeave);
            // 
            // viewMenu
            // 
            this.viewMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.viewMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.viewMenu.Location = new System.Drawing.Point(678, 43);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(117, 41);
            this.viewMenu.TabIndex = 30;
            this.viewMenu.Text = "View Menu";
            this.viewMenu.UseVisualStyleBackColor = false;
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            this.viewMenu.MouseEnter += new System.EventHandler(this.panel2EButtons_MouseEnter);
            this.viewMenu.MouseLeave += new System.EventHandler(this.panel2LButtons_MouseLeave);
            // 
            // salesdataGridView2
            // 
            this.salesdataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesdataGridView2.Location = new System.Drawing.Point(24, 36);
            this.salesdataGridView2.Name = "salesdataGridView2";
            this.salesdataGridView2.RowTemplate.Height = 24;
            this.salesdataGridView2.Size = new System.Drawing.Size(639, 416);
            this.salesdataGridView2.TabIndex = 24;
            // 
            // sales
            // 
            this.sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.sales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sales.Legends.Add(legend1);
            this.sales.Location = new System.Drawing.Point(814, 0);
            this.sales.Name = "sales";
            this.sales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.sales.Series.Add(series1);
            this.sales.Size = new System.Drawing.Size(546, 516);
            this.sales.TabIndex = 48;
            this.sales.Text = "Sales";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.secondpanel);
            this.Controls.Add(this.firstpanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant POS System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.firstpanel.ResumeLayout(false);
            this.firstpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menudataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.secondpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel firstpanel;
        private System.Windows.Forms.DataGridView menudataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button importbutton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel secondpanel;
        private System.Windows.Forms.Button viewSales;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sortItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear3;
        private System.Windows.Forms.Button chartbutton;
        private System.Windows.Forms.Button viewMenu;
        private System.Windows.Forms.DataGridView salesdataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart sales;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
    }
}