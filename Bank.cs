using System;

namespace _1_07.LINQed_List.Using_Custom_Types
{
    public class Bank
    {
        public string Name { get; set; }
        public int Millionaires { get; set; }
        //
        public static readonly Bank Default = new Bank()
        {
            Name = "",
            Millionaires = 0
        };
        public Bank()
        {
            Name = "";
            Millionaires = 0;
        }
        public Bank(string name)
        {
            Name = name;
            Millionaires = 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public void AddMil( int number )
        {
            Millionaires += number;
        }


    }
}
