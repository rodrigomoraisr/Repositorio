using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, };
            PrintFirstElement(myArray);

            List<int> myList = new List<int> { 1, 2, 3 };
            PrintFirstListElement(myList);
        }

        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The first element is {0}.\n", a[0]);
        }

        public static void PrintFirstListElement(List<int> a)
        {
            Console.WriteLine("The first list element is {0}.\n", a[0]);
        }

        public int[] ReturnUserInput()
        {
            int[] a = new int[3];

            for(int i = 1; i < a.Length; i++)
            {
                Console.WriteLine("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array.\n");
            }
            return a;
        }
    }
}
