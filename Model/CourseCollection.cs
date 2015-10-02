using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class CourseCollection
    {
        /*
         * Course definition for entire project, alter if you need
         * 2015/10/02 23:02 Cedric
         */
        public readonly static LinkedList<Course> courses = init();

        public static String find(String key)
        {
            if (key.Length > 1)
                foreach (Course c in courses)
                    if (c.key[0] == key[0])
                        if (!Char.IsDigit(key[1]))
                            return c.category;
                        else
                        {
                            int i = Int32.Parse(key[1].ToString()) - 1;
                            if (i < c.courses.Length && i >= 0)
                                return c.courses[i];
                        }

            return "";
        }

        static LinkedList<Course> init()
        {
            LinkedList<Course> courses = new LinkedList<Course>();

            courses.AddLast(new Course(
                "AA",
                "Kung Fu",
                new String[] { "Wing Chun", "Jeet Kune Do", "Thai Boxing" }
            ));

            courses.AddLast(new Course(
                "BB",
                "Cue Sports",
                new String[] { "Snooker", "8-Ball", "9-Ball" }
            ));

            courses.AddLast(new Course(
                "CC",
                "Music",
                new String[] { "Piano", "Violin" }
            ));

            return courses;
        }
    }

    class Course
    {
        public readonly String category;
        public readonly String[] courses;
        public readonly String key;

        public Course(String key, String category, String[] courses)
        {
            this.category = category;
            this.courses = courses;
            this.key = key;
        }
    }
}
