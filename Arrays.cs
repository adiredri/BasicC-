using System;

namespace Arrays
{
    class Program
    {

        //  arrays

        public static void Kelet(int[] a)            // temp function
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Pelet(int[] a)                // temp function
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write("  ");
            }
        }

        /*

         Questions 1 - 

         A pair of numbers will be called a "mirror pair" if the order of their digits is reversed, and also provided that both numbers are positive. 
         123 and 321 are a "mirror pair", 121 and 121 are a "mirror pair".
         An array is called a "mirror array" if every pair of values from the beginning and the end is a "mirror pair".
         A. A method must be written that accepts as a parameter a positive integer whose length is unknown and returns its appearance.
         B. Write a program that will take 10 positive integers of unknown length into a one-dimensional array. 
         The program will check and display an appropriate message whether the array is a "mirror array" or not. It is mandatory to use the method you wrote in the previous section.

        */

        public static int Mirror(int num)    // Q1
        {
            int op = 0;
            while (num != 0)
            {
                op = (op * 10) + (num % 10);
                num /= 10;
            }
            return op;
        }

        /*
         
         Questions 2 - 

         a. You must write a method that will accept as a parameter an integer whose length is unknown and return its length.
         B. A method must be written that accepts as parameters two positive integers of the same length and returns the number of digits in identical positions that have the same value.
         third. A program must be written that takes two arrays that are the same size (5 members) and contain only positive integers. 
         The program will build and display as output a new array that will contain for each pair of cells respectively where the numbers are the same length
         in both arrays the number of digits in identical positions that have the same value, otherwise -1 will appear. 
         It is mandatory to use the methods you wrote before and you can add additional methods as you wish.

        */

        public static int Length(int num)   // Q2
        {
            int c = 0;
            while (num != 0)
            {
                c++;
                num /= 10;
            }
            return c;
        }

        public static int CountIndex(int num1, int num2)
        {
            int count = 0;
            if (Length(num1) == Length(num2))
            {
                while (Length(num1) != 0)
                {
                    if ((num1 % 10) == (num2 % 10))
                        count++;
                    num1 /= 10;
                    num2 /= 10;
                }
                return count;
            }
            else
                return -1;
        }

        /*
         
         Questions 3 - 

         Write a program that takes 50 positive integers whose length is unknown to the array. 
         The program checks whether in the array in odd places there are numbers that consist of only even numbers and in even places there are numbers that consist of only odd numbers. 
         The program will display an appropriate message.

        */

        public static bool LoZugi(int[] a)  // Q3
        {
            bool flag = true;
            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    while (a[i] > 0)
                    {
                        if (a[i] % 2 != 0)
                            flag = false;
                        a[i] /= 10;
                    }
                }
            }
            return flag;
        }

        static void Main(string[] args)
        {
            //  q1

            Console.WriteLine("Enter array with 10 digits");
            int[] a = new int[10];
            int j = a.Length - 1;
            bool flag = true;
            Kelet(a);
            for (int i = 0; i < j; i++, j--)
            {
                if (a[i] != Mirror(a[j]))
                    flag = false;
            }
            if (flag == true)
                Console.WriteLine("The array is a mirror array");
            else
                Console.WriteLine("The array is not a mirror array");

            //  q2

            int[] a1 = new int[5];
            int[] a2 = new int[5];
            int[] a3 = new int[5];
            Console.WriteLine("Enter array 1 (5 numbers): ");
            Kelet(a1);
            Console.WriteLine("Enter array 2 (5 numbers): ");
            Kelet(a2);
            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = CountIndex(a1[i], a2[i]);
            }
            Console.WriteLine("The new array is : ");
            Pelet(a3);

            //   q3 

            int[] a4 = new int[50];
            Kelet(a4);
            if (LoZugi(a4) == true)
                Console.WriteLine("The array meets the necessary conditions");
            else
                Console.WriteLine("The array not meets the necessary conditions");

        }
    }
}
