using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public class Invoice
    {
        // Used as the dataset for rdlc
        public String staffName { get; set; }

        public String studentName { get; set; }
        public String contactNo { get; set; }
        public String email { get; set; }
        public String membership { get; set; }

        public String category { get; set; }
        public String course { get; set; }
        public String weekDay { get; set; }
        public String months { get; set; }
        public double subTotal { get; set; }

        public int discount { get; set; }
        public double lessonMaterial { get; set; }
        public double payment { get; set; }
    }
}
