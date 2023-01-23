using System;

namespace HelloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);

            //Estrutura condicional
            int userAge2;

            Console.WriteLine("Please enter your age: ");
            userAge2 = Convert.ToInt32(Console.ReadLine());

            if (userAge2 < 0 || userAge2 > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
            }
            else if (userAge2 < 18)
            {
                Console.WriteLine("Sorry you are underage");
            }
            else if(userAge2 < 21)
            {
                Console.WriteLine("You need parental consent");
            }
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!");
            }

            Console.WriteLine("Enter your grade: ");
            string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

            //Estrutura de repetição
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = {10,20,30,40,50 };
            for(int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            char[] message = { 'H', 'e', 'l', 'l', 'o','!' };
            foreach(char i in message)
            {
                Console.Write(i);
            }

            int counter = 5;
            while(counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter = counter - 1;
            }

            int counter2 = 100;

            do
            {
                Console.WriteLine("Counter = {0}", counter2);
                counter++;
            } while (counter2 < 0);

            int i2 = 0;
            for (i2 = 0; i2 < 5; i2++)
            {
                Console.WriteLine("i = {0}", i2);
                if (i2 == 2)
                    break;
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("i  {0}", i);
                if (i == 2)
                    continue;
                Console.WriteLine("I will not be printed if i = 2.\n");
            }
        }
    }
}
