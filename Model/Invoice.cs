using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class Invoice
    {
        public string staffName { get; set; }

        public string studentName { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }

        public string category { get; set; }
        public string course { get; set; }
        public string weekDay { get; set; }
        public string months { get; set; }
        public string subTotal { get; set; }

        public int discount { get; set; }
        public int lessonMaterial { get; set; }
    }
}
