using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte x = 10; //chapter 8
            //Console.WriteLine(x + "\r\n" + 11); //chapter 8
            //Console.WriteLine("HeyHey"); //chapter 8
            /* double x = 9.99;
            int y = (int)x;
            Console.WriteLine(y); */ //chapter 9

            // Chapter 12 - Array

            /* int[] numbers = { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers.Length); */

            /* string[] beatles = { "John", "Paul", "George", "Ringo" };
            string[] queen = { "Freddie", "Brian", "Roger", "John" };
            bool result = beatles.Equals(queen);
            Console.WriteLine(result); */

            /* string s1 = "29/12/2021";
            string[] result = s1.Split('/');
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]); */

            /* string date = "21/12/2021";
            string[] result = date.Split('1');
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]); */

            /* string[,] names = new string[2, 3];
            names[0, 0] = "Sefi";
            names[0, 1] = "Alex";
            names[0, 2] = "Yonatan";
            names[1, 0] = "Sharon";
            names[1, 1] = "Jackie";
            names[1, 2] = "Anatoli";
            Console.WriteLine(names[0, 0]); */

            /* string[,] names1 = { { "Jackie", "Alex", "Sharon" }, { "Anatoli", "Yuda", "Adiel" } };
            Console.WriteLine(names1[1, 2]); */

            // Chapter 13 - Get Input

            /* Console.WriteLine("Type your age:");
            var age = Console.ReadLine();
            Console.WriteLine("Your age is " + age); */

            // UserGetInput();
            OperatorsArythmetic();

            Console.ReadKey(); 
        }

        static void UserGetInput() //Chapter 14 - Get Input
        {
            Console.WriteLine("Enter your birth year");
            var birthyear = Console.ReadLine();
            var age = 2021 - Int32.Parse(birthyear);
            Console.WriteLine("Your age is " + age);
            Console.ReadKey();
        }

        static void OperatorsArythmetic() // Chapter 17
        {
            // Any text for revert
        }
    }
}