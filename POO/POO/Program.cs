﻿using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember mem2 = new VIPMember("Andy", 2, 2011);

            mem1.CalculateAnnualFee();
            mem2.CalculateAnnualFee();

            Console.WriteLine(mem1.ToString());
            Console.WriteLine(mem2.ToString());*/

            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach(Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

            if (clubMembers[0].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }

    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMemberSince: " + memberSince  + "\nTotal Annual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }

    class NormalMember : Member 
    { 
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public NormalMember(string remarks) : base("Jamie", 1, 2015)
        {
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince): base (name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince): base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }

}
