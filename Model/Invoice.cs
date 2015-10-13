using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public class Invoice
    {
        public string key;

        // Used as the dataset for rdlc
        public string staffName { get; set; }

        public string studentName { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string membership { get; set; }

        public string category { get; set; }
        public string course { get; set; }
        public string weekDay { get; set; }
        public string months { get; set; }
        public double subTotal { get; set; }

        public int discount { get; set; }
        public double lessonMaterial { get; set; }
        public double payment { get; set; }
    }
}
