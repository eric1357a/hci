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
        public readonly static LinkedList<Course> courses = initCourses();

        public static int Count
        {
            get { return courses.Count; }
        }

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

        static LinkedList<Course> initCourses()
        {
            LinkedList<Course> courses = new LinkedList<Course>();

            courses.AddLast(new Course(
                "AA",
                "Sports",
                new String[] { "Tennis", "Basketball", "Cue Sports" }
            ));

            courses.AddLast(new Course(
                "BB",
                "Visual Art",
                new String[] { "Snapshot", "Oil Painting", "Sketching" }
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

        public int Count
        {
            get { return courses.Length; }
        }

        public Course(String key, String category, String[] courses)
        {
            this.category = category;
            this.courses = courses;
            this.key = key;
        }
    }
}
