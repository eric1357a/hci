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
        private static LinkedList<Staff> Staffs = _InitStaffs();
        public static LinkedList<string> Deleted = new LinkedList<string>();


        public static Staff Login(string user, string pass)
        {
            foreach (Staff s in Staffs)
            {
                if (s.User == user && s.Pass == pass)
                    return s;
            }
            return null;
        }

        public static LinkedList<Staff> GetStaffs()
        {
            LinkedList<Staff> stfs = new LinkedList<Staff>();
            foreach (Staff s in Staffs)
                if (!Deleted.Contains(s.GetName()))
                    stfs.AddLast(s);
            return stfs;
        }

        public static JobPosition ToJobPosition(String jobPosition)
        {
            switch (jobPosition)
            {
                case "Manager":
                    return JobPosition.Manager;
                case "Admin":
                    return JobPosition.Admin;
                default:
                    return JobPosition.Staff;
            }
        }

        public static void Add(Staff s)
        {
            Staffs.AddLast(s);
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

    public class Staff : ICommonAttr
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
        public string GetName()
        {
            return User;
        }
    }
}
