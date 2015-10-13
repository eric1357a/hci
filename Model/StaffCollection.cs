using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public enum JobPosition
    {
        Staff, Manager, Admin
    }

    class StaffCollection
    {
        public static LinkedList<Staff> Staffs = _InitStaffs();


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
                "Peter",
                "1234",
                JobPosition.Staff
            ));
            members.AddLast(new Staff(
                "Alan",
                "1234",
                JobPosition.Manager
            ));
            members.AddLast(new Staff(
                "Ada",
                "1234",
                JobPosition.Admin
            ));
            members.AddLast(new Staff(
                "Cedric",
                "1234",
                JobPosition.Staff
            ));
            return members;
        }

    }

    public class Staff
    {
        public string User;
        public string Pass;
        public JobPosition Role;
        public Staff(string user, string pass, JobPosition role)
        {
            User = user;
            Pass = pass;
            Role = role;
        }
    }
}
