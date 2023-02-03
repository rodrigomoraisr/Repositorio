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

            int[] myArray2 = ReturnUserInput();

            List<int> myList2 = ReturnUserInputList();

            PrintNames("Peter");
            PrintNames("Yvonne", "Jamie");
            PrintNames("Abigail", "Betty", "Carol", "David");

            int a = 2;
            int[] b = { 1, 2, 3 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);
            Console.WriteLine("\n\n");
            Console.WriteLine("b[0] before {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);
        }

        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The first element is {0}.\n", a[0]);
        }

        public static void PrintFirstListElement(List<int> a)
        {
            Console.WriteLine("The first list element is {0}.\n", a[0]);
        }

        public static int[] ReturnUserInput()
        {
            int[] a = new int[3];

            for(int i = 1; i < a.Length; i++)
            {
                Console.Write("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array.\n");
            }
            return a;
        }

        public static List<int> ReturnUserInputList()
        {
            List<int> a = new List<int>();
            int input;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter an Integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to list.\n");
                a.Add(input);
            }
            return a;
        }
        
        public static void PrintNames(params string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class MethodDemo
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("a inside method = {0}", a);
        }

        public void PassByReference(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }
    }
}
