using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace firstProgram
{
    internal class IFELSEquestions
    {
        public static void q10(double salary)
        {
            //Write a C# program to input basic salary of an employee and calculate its  
            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
            //DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %
            double gsal = 0;
            if (salary <= 10000)
            {
                 gsal = salary + (salary * 0.20) + (salary * 0.80);
            }
            else if (salary <= 20000)
            {
                 gsal = salary + (salary * 0.25) + (salary * 0.90);
            }
            else if (salary > 20000)
            {
                 gsal = salary + (salary * 0.30) + (salary * 0.95);
            }
            Console.WriteLine("gross sal is "+gsal);
        }
        public static void q9(int month)
        {
            //Write a C# program print total number of days in a month
            if (month % 2 == 0)
            {
                Console.WriteLine("there are 31 days in this month ");
            }
            else
            {
                Console.WriteLine("there are 30 days in this month");
            }
        }
        public static void q8(int n)
        {
            //Write a C# program to check whether a number is even or odd
            if (n % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
        public static void q7(char a) 
        {
            //Write a C# program to input any character and check whether it is alphabet, digit or special character
            if (Char.IsDigit(a))
            {
                Console.WriteLine("the entered character is a digit");
            }
            else if (Char.IsLetter(a))
            {
                Console.WriteLine("the entered character is a alphabet");
            }
            else if (Char.IsSymbol(a))
            {
                Console.WriteLine("the entered character is a special character");
            }
        }
        public static void q6(int n)
        {
            //Write a C# program to check whether a number is negative, positive or zero
            
                if (n > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (n < 0)
               {
                    Console.WriteLine("negative");
                }
                else {
                    Console.WriteLine("zero");
                }
        }
        public static void q5(int n1,int n2)
        {
            //Write a C# program to create Simple Calculator
            Console.WriteLine("enter the operation (+,-,*,/)");
            char a=Convert.ToChar(Console.ReadLine());
            if (a == '+')
            {
                Console.WriteLine("ans:- " + (n1 + n2));
            }
            else if (a == '-')
            {
                Console.WriteLine("ans:- " + (n1 - n2));
            }
            else if (a == '*')
            {
                Console.WriteLine("ans:- " + (n1 * n2));
            }
            else if (a == '/')
            {
                Console.WriteLine("ans:- " + (n1 / n2));
            }
        }
        public static void q4(char a)
        {
            //Write a C# program to input any alphabet and check whether it is vowel or consonant
            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                Console.WriteLine("the character is a vowel");
            }
            else
            {
                Console.WriteLine("the character is a consonant");
            }
        }
        public static void q3(int n1,int n2,int n3) 
        {
            //Write a C# program to find maximum between three numbers 
            int num=(n1>n2)?n1:n2;
            if (num > n3)
            {
                Console.WriteLine(num+"is the greatest number");
            }
            else
            {
                Console.WriteLine(n3+"is the greatest number");
            }
        }
        public static void q2(int n)
        {
            //Write a C# program to check whether a number is divisible by 5 and 11 or not
            if (n % 5 == 0 && n % 11 == 0)
            {
                Console.WriteLine("the number is divisible by 5 and 11 ");
            }
        }
        public static void q1(int n)
        {
            //1. Write a C# program to check whether a year is leap year or not 
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                    {
                        Console.WriteLine (n + " is a leap year");
                    }
                    else
                    {
                        Console.WriteLine(n + " is a leap year");
                    }
                }
                else
                {
                    Console.WriteLine(n + " is a leap year");
                }
            }
            else
            {
                Console.WriteLine(n + " is a leap year");
            }
        }
        //static void Main(string[] args)
        //{
            int year = 1904;
           // q1(year);
            int n = 55;
            //q2 (n);
            int n2 = 33, n3 = 11;
            // q3(n, n2, n3);
            char a = 'a';
            //q4(a);
            //q5(n, n2);
            //q6(n);
            // q7(a);
            //q8(n);
            //q9(10);
            //q10(40000);
        //}
    }
}
