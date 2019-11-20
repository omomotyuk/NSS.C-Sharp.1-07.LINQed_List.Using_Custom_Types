using System;
using System.Collections.Generic;

namespace _1_07.LINQed_List.Using_Custom_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            List<Bank> banks = new List<Bank>();

            foreach( Customer customer in customers )
            {
                string name = customer.Bank;
                if( banks.Count == 0 )
                {
                    banks.Add(new Bank(name));
                }
                else
                {
                    try
                    {
                        Bank temp = banks.Find(item => item.Name == name);
                        if(temp.Name == name ){}
                    }
                    catch (Exception ex )
                    {
                        banks.Add(new Bank(name));
                    }
                }
            }

            foreach( Bank bank in banks )
            {
                int number = customers.FindAll( item => FindMill( bank, item) ).Count;
                bank.AddMil( number );
            }

            Console.WriteLine("Number of millionaires in each bank:");
            foreach( Bank bank in banks )
            {
                Console.WriteLine($"{bank.Name} {bank.Millionaires}");
            }
        }

        static bool FindMill( Bank bank, Customer customer )
        {
            bool value = false;
            if( (customer.Bank == bank.Name) && (customer.Balance >= 1000000.00) )
            {
                value = true;
            }
            return value;
        }
    }
}
