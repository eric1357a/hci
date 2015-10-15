using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    enum SearchCriteria
    {
        Price,
        PriceRange,
        AvailablePlaces,
        AvailablePlacesForMonth
    }

    class CourseCollection
    {
        public static LinkedList<Programme> Programmes = _InitProgrammes();
        public static LinkedList<string> Deleted = new LinkedList<string>();
        private Programme item;

        public static int Count
        {
            get { return Programmes.Count; }
        }

        public static Course ElementAt(string programme, string name)
        {
            for (int i = 0; i < Programmes.Count; i++)
            {
                Programme p = ((Programme)Programmes.ElementAt(i));
                if (p.Category == programme)
                    for (int j = 0; j < p.Courses.Length; j++)
                        if (p.Courses[j].Name == name)
                            return p.Courses[j];
            }
            return null;
        }

        public static object[] Search(SearchCriteria sc, object[] args)
        {
            LinkedList<ListItem> data = new LinkedList<ListItem>();
            foreach (Course c in GetCourses())
                switch (sc)
                {
                    case SearchCriteria.Price:
                        if (c.Cost == (Int32)args[0])
                            data.AddLast(new ListItem(c.GetName(), c));
                        break;
                    case SearchCriteria.PriceRange:
                        if (c.Cost >= (Int32)args[0] && c.Cost <= (Int32)args[1])
                            data.AddLast(new ListItem(c.GetName(), c));
                        break;
                    case SearchCriteria.AvailablePlaces:
                        if (c.Seats == (Int32)args[0])
                            data.AddLast(new ListItem(c.GetName(), c));
                        break;
                    case SearchCriteria.AvailablePlacesForMonth:
                        if (c.Seats == (Int32)args[0] && c.Day == (string)args[1])
                            data.AddLast(new ListItem(c.GetName(), c));
                        break;
                }
            return data.ToArray();
        }

        public static string GetKeyByName(string name)
        {
            char currentCat = 'A';
            int i = 1;
            foreach (Programme p in Programmes)
            {
                i = 1;
                currentCat = p.Key[0];
                foreach (Course c in p.Courses)
                {
                    if (c.GetName() == name)
                        return currentCat + "" + i;
                    i++;
                }
            }
            return null;
        }

        public static Programme Search(string key)
        {
            if (key.Length > 1)
                foreach (Programme c in Programmes)
                    if (c.Key[0] == key[0])
                        return c;
            return null;
        }

        public static Programme FindProgramme(string key)
        {
            if (key.Length > 1)
                foreach (Programme c in Programmes)
                    if (c.Key[0] == key[0])
                        return c;
            return null;
        }

        public static void Add(string progNo, Course c)
        {
            foreach (Programme p in Programmes)
            {
                if(progNo[0] == p.Key[0]){
                    Course[] newCourses = new Course[p.Courses.Length + 1];
                    for (int k = 0; k < p.Courses.Length; k++)
                    {
                        newCourses[k] = p.Courses[k];
                    }
                    newCourses[p.Courses.Length] = c;
                    p.Courses = newCourses;
                }
            }
        }

        public static LinkedList<Course> GetCourses()
        {
            LinkedList<Course> courses = new LinkedList<Course>();
            foreach (Programme p in Programmes)
                foreach (Course c in p.Courses)
                    if(!Deleted.Contains(c.GetName()))
                        courses.AddLast(c);
            return courses;
        }

        private static LinkedList<Programme> _InitProgrammes()
        {
            LinkedList<Programme> programmes = new LinkedList<Programme>();

            programmes.AddLast(new Programme(
                "AA",
                "Sports",
                200,
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
                500,
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
                1000,
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
        public string Category;
        public Course[] Courses;
        public string Key;
        public int MaterialFee;

        public int Count
        {
            get { return Courses.Length; }
        }

        public Programme(string key, string category, int materialFee, Course[] courses)
        {
            Category = category;
            Courses = courses;
            Key = key;
            MaterialFee = materialFee;
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

    class Course : ICommonAttr
    {
        public string Name;
        public string Desc;
        public string Day;
        public int Cost;
        public int Seats;

        public Course(string name, string desc, string day, int cost, int seats = 10)
        {
            Name = name;
            Desc = desc;
            Day = day;
            Cost = cost;
            Seats = seats;
        }
        public string GetName()
        {
            return Name;
        }

    }
}
