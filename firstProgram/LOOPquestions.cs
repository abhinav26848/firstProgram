using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram
{
    internal class LOOPquestions
    {
        public static void q12()
        {
            // check no is automorphic or not
            //input n = 25
            //output Automorphic
            //as 25 * 25 = 625
            int n = 25,sqr,temp,x;
                sqr = n * n;
                temp = n % 10;
                x = sqr % 10;
            if (x == temp)
            {
                Console.WriteLine("number is atuomorphic");
            }
            else
            {
                Console.WriteLine("number is not atuomorphic");
            }


        }
        public static void q11()
        {
            //Find out if the given number is palindrome or not
            int n = 12321;
                int reverse = 0;
                int temp = n;
                while (temp != 0)
                {
                    reverse = (reverse * 10) + (temp % 10);
                    temp = temp / 10;
                }
                string result=(reverse == n)?"palendrome":"not palendrome";
                Console.WriteLine(result);
        }
        public static void q10()
        {
            //Find the sum of all digits of a number.
            int num = 1234,sum=0,temp=0;
            
            while (num!=0)
            {
                temp = num % 10;
                sum=sum+temp;
                num = num / 10;
            }
            Console.WriteLine("the sum of all digits of 1234 is "+sum);
        }
        public static void q9(int n)
        {
            //Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ..... k. where k < n . n is entered by user
            int num1 = 0, num2 = 1;

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(num1 + " ");

                
                int num3 = num2 + num1;
                num1 = num2;
                num2 = num3;
            }
        }
        public static void q8()
        {
            //Count the number of digits in any number.
            int num = 1234,count=0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine("the number has "+count+" digits");
        }
        public static void q7()
        {
            //Calculate factorial of a number.
            int num = 8;
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("the factorial of "+num+" is "+sum);
        }
        public static void q6()
        {
            //Find all prime numbers < 100.
            for (int i = 2; i <=100 ; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {  
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
        public static void q5()
        {
            //Find the first 10 even numbers
            int temp = 0;
            for (int i = 0; i < 100; i++)
            {
                
                if (i % 2 != 0)
                {
                    if (temp > 9)
                    { break; }
                    else
                    {
                        Console.WriteLine(i);
                        temp++;
                    }
                }
            }
        }
        public static void q4()
        {
            //Display the seventh element between 400 to 500 (both numbers excluded).
            for (int i = 400; i <500 ; i=i+7)
            {
                if(i!=400)
                Console.WriteLine(i);
            }
        }
        public static void q3()
        {
            //Display all odd numbers from 200 to 300.
            for (int i = 200; i <= 300; i++)
            {
                if (i % 2 != 0)
                { Console.WriteLine(i); }
            }
        }
        public static void q2()
        {
            //Display all even numbers from 1 to 100.
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                { Console.WriteLine(i); }
            }
        }
        public static void q1()
        {
            //Display numbers from 1 to 100.
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
       // static void Main(string[] args)
       // {
            // q1();
            //q2 ();
            //q3();
            //q4();
            //q5();
            //q6();
            //q7();
            //q8();
            //q9(10);
            // q10();
            //q11();
           // q12();
        //}

    }
}
