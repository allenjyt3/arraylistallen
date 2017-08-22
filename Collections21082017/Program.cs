using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections21082017
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding some numbers");

            al.Add(14);
            al.Add(25);
            al.Add(456);
            al.Add(2);
            al.Add(65);
            al.Add(3);
            al.Add(11);

            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("COUNT: {0}", al.Count);

            Console.WriteLine("Content:");
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }


            Console.WriteLine("Sorted Content:");
            al.Sort();
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }



            Console.WriteLine("Reversed Content:");
            al.Reverse();
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }

            al.TrimToSize();
            Console.WriteLine();
            al.Insert(7, 78);

            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }
            Console.WriteLine("Capacity: {0}", al.Capacity);
            
            Console.WriteLine();
            al.Remove(78);
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }

            Console.WriteLine();
            al.RemoveAt(4);
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }

            Console.WriteLine();
            al.RemoveRange(3, 3);

            foreach (int i in al)
            {
                Console.WriteLine(i + " ");

            }



            Console.ReadKey();
        }
    }



   

}
