using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HCI.Model
{
    enum Membership
    {
        None, Gold, Normal
    }

    class StudentCollection
    {
        private static LinkedList<Student> students = _initStudents();

        public static Membership ToMembership(String membership)
        {
            switch (membership)
            {
                case "Normal":
                    return Membership.Normal;
                case "Gold":
                    return Membership.Gold;
                default:
                    return Membership.None;
            }
        }

        public static Student ElementAt(string name, Membership membership)
        {
            for (int i = 0; i < students.Count; i++)
                if (students.ElementAt(i).name == name)
                    if (students.ElementAt(i).membership == membership)
                        return students.ElementAt(i);
            return null;
        }

        public static void Add(string name, string contactNo, string email, Membership membership)
        {
            students.AddLast(new Student(name, contactNo, email, membership));
        }

        private static LinkedList<Student> _initStudents()
        {
            LinkedList<Student> s = new LinkedList<Student>();
            return s;
        }
    }

    class Student
    {
        private LinkedList<Dictionary<string, bool>> juneJulyAugust;
        public string name;
        public string contactNo;
        public string email;
        public Membership membership;

        public Student(string name, string contactNo, string email, Membership membership)
        {
            juneJulyAugust = new LinkedList<Dictionary<string, bool>>();
            for (int i = 0; i < 3; i++)
                juneJulyAugust.AddLast(_initMonth());

            this.name = name;
            this.contactNo = contactNo;
            this.email = email;
            this.membership = membership;
        }

        public void register(string dayOfWeek, bool[] JuneJulyAugust)
        {
            try
            {
                for (int i = 0; i < juneJulyAugust.Count; i++)
                    if (JuneJulyAugust[i])
                        juneJulyAugust.ElementAt(i)[dayOfWeek] = true;
            }
            catch (Exception e)
            {
                return;
            }
        }

        public bool checkOccupation(string dayOfWeek, bool[] JuneJulyAugust)
        {
            try
            {
                for (int i = 0; i < juneJulyAugust.Count; i++)
                    if (JuneJulyAugust[i])
                        if (juneJulyAugust.ElementAt(i)[dayOfWeek])
                            return true;
            }
            catch (Exception e)
            {
                return true;
            }
            return false;
        }

        private Dictionary<string, bool> _initMonth()
        {
            Dictionary<string, bool> month = new Dictionary<string, bool>();

            month.Add("Sun", false);
            month.Add("Mon", false);
            month.Add("Tue", false);
            month.Add("Wed", false);
            month.Add("Thu", false);
            month.Add("Fri", false);
            month.Add("Sat", false);

            return month;
        }
    }
}
