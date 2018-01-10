using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    [Serializable]
    class Serialize
    {
        public string item { get; set; }
        public string category { get; set; }
        public string price { get; set; }
    }
}
