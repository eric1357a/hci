using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class StaffCollection
    {
        public readonly static LinkedList<Staff> Staffs = _InitStaffs();


        public static Staff Login(string user, string pass)
        {
            foreach (Staff s in Staffs)
            {
                if (s.User == user && s.Pass == pass)
                    return s;
            }
            return null;
        }

        private static LinkedList<Staff> _InitStaffs()
        {
            LinkedList<Staff> members = new LinkedList<Staff>();
            members.AddLast(new Staff(
                "peter",
                "1234",
                false
            ));
            members.AddLast(new Staff(
                "alan",
                "1234",
                true
            ));
            return members;
        }

    }

    class Staff
    {
        public readonly string User;
        public readonly string Pass;
        public readonly bool Manager;
        public Staff(string user, string pass, bool manager)
        {
            User = user;
            Pass = pass;
            Manager = manager;
        }
    }
}
