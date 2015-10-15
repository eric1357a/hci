using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class TeacherCollection
    {
        private static LinkedList<Teacher> teachers = _InitTeachers();

        private static LinkedList<Teacher> _InitTeachers()
        {
            LinkedList<Teacher> ll = new LinkedList<Teacher>();

            ll.AddLast(new Teacher(
                "Sunny",
                "66778964",
                "Teaching assistant"
            ));

            ll.AddLast(new Teacher(
                "Andy",
                "23645178",
                "Senior Lecturer"
            ));

            return ll;
        }
    }

    class Teacher
    {
        public string Name;
        public string Tel;
        public string Title;

        public Teacher(string name, string tel, string title)
        {
            Name = name;
            Tel = tel;
            Title = title;
        }
    }
}
