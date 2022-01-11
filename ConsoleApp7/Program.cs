using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hemanth", "Rohith", "Surya",
                       "Manoj", "Naveen", "Sowmya",
                       "Bhavya", "Suman" };
            //Using LINQ Queries
            UsingLinq(names);
        }

        private static void UsingLinq(string[] names)
        {
            IEnumerable<string> query = from a in names
                                        where a.Length == 5
                                        orderby a
                                        select a.ToUpper();
            //select * from
            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();

        }
    }
}