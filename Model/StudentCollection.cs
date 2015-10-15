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
        private static LinkedList<Student> Students = _InitStudents();
        public static LinkedList<string> Deleted = new LinkedList<string>();

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

        public static LinkedList<Student> GetStudents()
        {
            LinkedList<Student> stus = new LinkedList<Student>();
            foreach (Student s in Students)
                if (!Deleted.Contains(s.GetName()))
                    stus.AddLast(s);
            return stus;
        }

        public static void Add(Student s)
        {
            Students.AddLast(s);
        }

        private static LinkedList<Student> _InitStudents()
        {
            LinkedList<Student> studs = new LinkedList<Student>();
            studs.AddLast(new Student(
                "Tom",
                "90315689",
                "Tom@vtc.edu.hk",
                Membership.Normal
            ));
            studs.AddLast(new Student(
                "Jimmy",
                "96511234",
                "Jimmy@vtc.edu.hk",
                Membership.Gold
            ));
            studs.AddLast(new Student(
                "Mary",
                "62358777",
                "Mary@vtc.edu.hk",
                Membership.None
            ));
           
            return studs;
        }
        public static Student ElementAt(string name, Membership membership)
        {
            for (int i = 0; i < Students.Count; i++)
                if (Students.ElementAt(i).name == name)
                    if (Students.ElementAt(i).membership == membership)
                        return Students.ElementAt(i);
            return null;
        }

        public static void Add(string name, string contactNo, string email, Membership membership)
        {
            Students.AddLast(new Student(name, contactNo, email, membership));
        }

        private static LinkedList<Student> _initStudents()
        {
            LinkedList<Student> s = new LinkedList<Student>();
            return s;
        }
    }

    class Student : ICommonAttr
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

        public string GetName()
        {
            return name;
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
