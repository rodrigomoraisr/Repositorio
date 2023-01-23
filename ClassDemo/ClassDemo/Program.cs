using System;

namespace ClassDemo
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", Hourly Rate = " + hourlyRate + ", hWorked = " + hWorked;
        }

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("---------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int pay;

            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
        }
    }

    class MyClass
    {
        //Non static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //Para acessar propriedades, variáveis e métodos statics não é necessário declarar um objeto apenas NomeClasse.nomePropriedade
        //Static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }

    //Classes statics só podem conter elementos statics
    static class MyStaticClass
    {
        public static int a = 0;
        public static int b{ get;set; }
    }
}
