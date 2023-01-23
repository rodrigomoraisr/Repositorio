using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLOS DE DECLARAÇÃO DE VARIÁVEIS
            byte userAge = 20;
            int numberOfEmployees = 510;

            //INICIALIZANDO DOUBLE, FLOAT E DECIMAL COM NÚMEROS INTEIROS
            double intNumberOfHours = 5120;
            float intHourlyRate = 60;
            decimal intIncome = 25339;

            //INICIALIZANDO DOUBLE, FLOAT E DECIMAL COM NÚMEROS NÃO INTEIROS
            double numberOfHours = 5120.5;
            float hourlyRate = 60.5f;
            decimal income = 25399.65m;

            char grade = 'A';

            bool promote = true;

            //INICIALIZANDO VARIÁVEIS DO MESMO TIPO EM UMA DECLARAÇÃO
            byte level = 2, userExperience = 5;

            int x = 0;
            x = x + 2;
            x += 2;

            x = x - 2;
            x -= 2;

            x = x * 2;
            x *= 2;

            x++;
            x--;

            //CONVERSÃO DE DADOS
            int y = (int)20.9; // o resultado será 20

            float num1 = (float)20.9;
            decimal num2 = (decimal)20.9;

            //ARRAYS, STRINGS E LISTS
            int[] userAgeArray = { 21, 22, 23, 24, 25 }; //Array inicializada na declaração

            int[] userAgeArray2 = new int[5]; //Array declarada, mas não inicializada
            userAgeArray2 = new[] { 21, 22, 23, 24, 35 };

            Console.WriteLine(userAgeArray[0]); // 21 será exibido no console

            int tamanhoArray = userAgeArray.Length; // a variável vai receber o número de casas que a array possui

            int[] source = { 12, 1, 5, -2, 16, 14 };
            int[] dest = { 1, 2, 3, 4 };

            Array.Copy(source, dest, 3); //copia os três primeiros valores de source para dest

            int[] numbers = { 12, 1, 5, -2, 16, 14 };
            Array.Sort(numbers); //Organiza os números em ordem númerica

            //Verifica se o número existe na array, se sim retorna o índice onde o número aparece pela primeira vez, senão retorna -1
            int[] numbers2 = { 10, 30, 44, 21, 51, 21, 61, 224, 14 };
            Array.IndexOf(numbers2, 21);

            int ans = Array.IndexOf(numbers2, 21);

            //STRINGS
            string message = "Hello World";
            string anotherMessage = "";
            string myName = "Hellor World, " + "my name is Jamie";

            int tamanhoString = message.Length;

            string newMessage = message.Substring(2, 5); //retorna parte da string 5 caracteres depois da posição 2

            string firstString = "This is Jamie";
            string secondString = "secondString";
            firstString.Equals("This is Jamie"); //compara se os valores das strings são iguais, retorna verdadeiro ou falso
            firstString.Equals(secondString);

            string[] separator = { ",", ";" }; //cria uma lista de separadores
            string names = "Peter, John; Andy, David";
            string[] substrings = names.Split(separator, StringSplitOptions.None); //Divide as strings divididas pelos separadores
            substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries); //Remove valores em branco

            //LISTAS
            List<int> userAgeList = new List<int>();//Lista declarada, mas não inicializada
            List<int> userAgeList2 = new List<int>() { 11, 21, 31, 41 };//Lista declarada e inicializada

            userAgeList.Add(51);//adiciona 1 item na lista

            int listLength = userAgeList.Count; //retorna a quantidade de elementos na lista

            userAgeList2.Insert(2, 51); //adiciona um novo valor na lista em uma posição específica

            userAgeList2.Remove(51); //remove a primeira ocorrência do valor na lista
            userAgeList2.RemoveAt(3); //Remove um valor da lista em uma posição específica
            userAgeList2.Contains(51); //verifica se a lista contém o valor passado, retorna true ou false
            userAgeList2.Clear(); //limpa a lista, remove todos os valores

            int results = 79;
            Console.WriteLine("{0}! You scored {1} marks for your test.", "Good morning", results);
            Console.WriteLine("The number is {0:F3}.", 123.45678); // O resultado esperado é 123.457

            // Resultado: Deposit = $2,125.00. Account balance = $12,345.68
            Console.WriteLine("Deposit = {0:C}. Account balance = {1:C}.", 2125, 12345.678);

            Console.WriteLine("Hello World".Length);

            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
