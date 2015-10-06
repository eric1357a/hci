using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class MemberCollection
    {
        public readonly static LinkedList<Member> Members = _InitMembers();


        public static Member Login(string user, string pass)
        {
            foreach (Member m in Members)
            {
                if (m.User == user && m.Pass == pass)
                    return m;
            }
            return null;
        }

        private static LinkedList<Member> _InitMembers()
        {
            LinkedList<Member> members = new LinkedList<Member>();
            members.AddLast(new Member(
                "peter",
                "1234",
                "F",
                false,
                "Normal"
            ));
            members.AddLast(new Member(
                "alan",
                "1234",
                "M",
                true,
                "Gold"
            ));
            return members;
        }

    }

    class Member
    {
        public readonly string User;
        public readonly string Pass;
        public readonly string Gender;
        public readonly bool Staff;
        public readonly string Type;
        public Member(string user, string pass, string gender, bool staff, string type)
        {
            User = user;
            Pass = pass;
            Gender = gender;
            Staff = staff;
            Type = type;
        }
    }
}
