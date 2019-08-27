using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class Program
    {
        const int pageelements = 5;
        static List<string> mylist;
        static List<string> newlist;

        public static void DisplayPage(int pageNumber)
        {
            int number = pageNumber * pageelements - 5;
            if (pageNumber > newlist.Capacity / 5)
            {
                Console.WriteLine("Wrong page!");
            }

            else
            {
                for (int i = number; i < number + 5; i++)
                {
                    Console.Write(newlist[i] + ",");
                }
            }



        }




        static void Main(string[] args)
        {
            mylist = new List<string>(200);
            //List<string> mylist = new List<string>(200);
            int x;
            StringBuilder element = new StringBuilder(4);
            Random r = new Random();
            for (int i = 0; i < mylist.Capacity; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    x = r.Next(65, 91);
                    element.Append((char)x);
                }
                mylist.Add(element.ToString());
                element.Clear();
            }

            int amount1 = mylist.Count;


            mylist.Sort();
            mylist.Reverse();

             newlist = mylist.Distinct().ToList();
            newlist.RemoveAll(str => str[0] == 'Z');


            int amount2 = newlist.Count;
            Console.WriteLine("Before transformations: {0}, After: {1}", amount1, amount2);
            int n = 0;
            Console.Write("Enter number of page:");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Environment.Exit(0);
            }



            foreach (var el in newlist)
            {
                Console.Write(el + ", ");
            }

            Console.WriteLine();

            Console.WriteLine($"Page {n}:");
            DisplayPage(n);



            Console.ReadLine();

        }


    }
}
