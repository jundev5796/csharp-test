﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            PrintHello(); // output

            // 2.
            PrintMessage("Hi");

            // 3.
            int num = GetNumber();
            Console.WriteLine(num);

            // 4.
            int result = Add(3, 5);
            Console.WriteLine(result);

            // 5.
            Greet();
            Greet("Tom");

            // 6.
            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(Multiply(2.5, 3.5));
        }

        // 1. Function (no parameter, no return value)
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        // 2. Function w/ parameter
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // 3. Function w/ return value
        static int GetNumber()
        {
            return 42;
        }

        // 4. Function w/ parameter + return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 5. Function w/ default parameter
        static void Greet(string name = "User")
        {
            Console.WriteLine($"Hello, {name}");
        }

        //6. Function overloading
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
