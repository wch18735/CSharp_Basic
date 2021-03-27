using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            Variable v = new Variable();
            v.print_variable();

            // Strings
            Strings s = new Strings();
            s.print_string();

            // Numbers
            Numbers n = new Numbers();
            n.print_numbers();

            // Inputs
            Inputs i = new Inputs();
            i.print_inputs();

            // Typecast
            Calculator c = new Calculator();
            c.print_calculator();

            // Arrays
            Arrays a = new Arrays();
            a.print_arrays();
        }
    }

    class Variable
    {
        public void print_variable()
        {
            Console.WriteLine("============== Practice to handle variables ============");
            Console.Write("이름:");
            string characterName = Console.ReadLine();
            Console.Write("나이:");
            string characterAge = Console.ReadLine();

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
        }
    }

    class Strings
    {
        public void print_string()
        {
            Console.WriteLine("============== Practice to handle string ============");
            string phrase1 = "Won";
            string phrase2 = "Cheol";
            string phrase3 = "Hwang";
            Console.WriteLine("Concat phrases: " + phrase1 + phrase2 + phrase3);
            Console.WriteLine("phrase1 length: " + phrase1.Length);
            Console.WriteLine("phrase2 length: " + phrase2.Length);
            Console.WriteLine("phrase1 upper: " + phrase1.ToUpper());
            Console.WriteLine("phrase2 lower: " + phrase2.ToLower());
            Console.WriteLine("phrase1 contains e? " + phrase1.Contains("e"));
            Console.WriteLine("phrase3 starts with: " + phrase3[0]);
            Console.WriteLine("IndexOf \"ng\" in" + phrase3 + ": " + phrase3.IndexOf("ng"));
            Console.WriteLine("Substring of phrase2 = " + phrase2 +" by (1, 2) = (index, length): " + phrase2.Substring(1, 2));
        }
    }

    class Numbers
    {
        public void print_numbers()
        {
            Console.WriteLine("============== Practice to handle numbers ============");
            Console.WriteLine("5 + 8 = " + (5 + 8));
            Console.WriteLine("8 / 3 = " + (8 / 3));
            Console.WriteLine("8.0 / 3.0 = " + (8.0 / 3.0));
            Console.WriteLine("Math.Round(8.0 / 3.0, 2) = " + Math.Round(8.0 / 3.0, 2));
            Console.WriteLine("Math.Floor(8.0 / 3.0) = " + Math.Floor(8.0 / 3.0));
            Console.WriteLine("Math.Ceiling(8.0 / 3.0) = " + Math.Ceiling(8.0 / 3.0));
        }
    }

    class Inputs
    {
        public void print_inputs()
        {
            Console.WriteLine("============== Practice to handle input ============");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("This is " + userName + "!" + " I'm " + userAge);
        }
    }

    class Calculator
    {
        public void print_calculator()
        {
            Console.WriteLine("============== Practice to handle typecast ============");
            Console.Write("Enter first number: ");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result is " + (first_num + second_num));
        }
    }

    class Arrays
    {
        public void print_arrays()
        {
            Console.WriteLine("============== Practice to handle arrays ============");

            // assign array variable
            int[] luckyNumber = { 4, 8, 15, 16, 42 };

            for(int i = 0; i < luckyNumber.Length; i++) Console.Write(luckyNumber[i] + " ");
            Console.WriteLine();

            // don't know
            // variable_type variable_name = craete_instructions variable_type[number of element]
            string[] friends = new string[5];
            friends[0] = "Katy";
            friends[1] = "John";

            // 2d Array: access by [row, col] not [row][col]
            int[,] numberGrid ={
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            Console.WriteLine("numberGrid[1, 2]" + numberGrid[1, 2]);
        }
    }
}