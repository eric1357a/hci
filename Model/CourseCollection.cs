using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class CourseCollection
    {
        public readonly static LinkedList<Programme> Programmes = _InitProgrammes();

        public static int Count
        {
            get { return Programmes.Count; }
        }

        public static Programme FindProgramme(string key)
        {
            if (key.Length > 1)
                foreach (Programme c in Programmes)
                    if (c.Key[0] == key[0])
                        return c;
            return null;
        }

        private static LinkedList<Programme> _InitProgrammes()
        {
            LinkedList<Programme> programmes = new LinkedList<Programme>();

            programmes.AddLast(new Programme(
                "AA",
                "Sports",
                new Course[] {
                    new Course("Tennis",
                        "Tennis is a racquet sport that can be played "+
                            "individually against a single opponent (singles) or "+
                            "between two teams of two players each (doubles).",
                        "Mon",
                        400),
                    new Course("Basketball",
                        "Basketball is a sport played by two teams of five "+
                            "players on a rectangular court.",
                        "Tue",
                        700),
                    new Course("Cue Sports",
                        "A wide variety of games of skill generally played with "+
                            "a cue stick which is used to strike billiard balls.",
                        "Wed",
                        800)
                }
            ));

            programmes.AddLast(new Programme(
                "BB",
                "Arts",
                new Course[] {
                    new Course("Snapshot",
                        "A photograph that is \"shot\" spontaneously and quickly, "+
                            "most often without artistic or journalistic intent.",
                        "Tue",
                        500),
                    new Course("Oil Painting",
                        "Oil painting is the process of painting with pigments "+
                            "that are binded with a medium of drying oil.",
                        "Wed",
                        500),
                    new Course("Sketching",
                        "A rapidly executed freehand drawing that is not usually "+
                            "intended as a finished work.",
                        "Fri",
                        600)
                }
            ));

            programmes.AddLast(new Programme(
                "CC",
                "Music",
                new Course[] {
                    new Course("Piano",
                        "A musical instrument played using a keyboard.",
                        "Thur",
                        350),
                    new Course("Violin",
                        "The smallest, highest-pitched member of the violin "+
                            "family of string instruments.",
                        "Fri",
                        380),
                }
            ));

            return programmes;
        }
    }

    class Programme
    {
        public readonly string Category;
        public readonly Course[] Courses;
        public readonly string Key;

        public int Count
        {
            get { return Courses.Length; }
        }

        public Programme(string key, string category, Course[] courses)
        {
            this.Category = category;
            this.Courses = courses;
            this.Key = key;
        }

        public Course Find(string key)
        {
            if (Char.IsDigit(key[1]) && key[0] == this.Key[0])
            {
                int i = Int32.Parse(key[1].ToString()) - 1;
                if (i < this.Courses.Length && i >= 0)
                    return this.Courses[i];
            }
            return null;
        }
    }

    class Course
    {
        public readonly string Name;
        public readonly string Desc;
        public readonly string Day;
        public readonly int Cost;

        public Course(string name, string desc, string day, int cost)
        {
            Name = name;
            Desc = desc;
            Day = day;
            Cost = cost;
        }
    }
    
}
