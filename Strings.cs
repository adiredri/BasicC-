using System;

namespace Strings
{

    //  Strings Questions

    class Program
    {
        /*
         
        Question 1 - 
        Write a method that accepts a string as a parameter. 
        The method will return a new string with no duplicate characters in the sequence. For example: 
        if the original string contains the letters caaaBBBBzc then the new string will contain caBzc.
  
        */

        public static string Kefel(string st)
        {
            Console.WriteLine("Type some string");
            st = Console.ReadLine();
            string st1 = "";
            st1 += st[0];

            for (int i = 0; i < st.Length - 1; i++)
            {
                if (st[i] != st[i + 1])
                {
                    st1 += st[i + 1];
                }
            }
            return st1;
        }

        /*

        Question 2 - 
        Write a method that accepts as a parameter a string and two natural numbers X and Y. 
        Create a new string in which an exchange was made between X the last characters in the string and Y the first characters. 
        The method will return the newly created string.

        */

        public static string Switch(string st, int x, int y)
        {
            Console.WriteLine("Please enter string, and two numbers");
            st = Console.ReadLine();
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            while (x + y > st.Length)
            {
                Console.WriteLine("Error , try again");
                Console.WriteLine("Please enter string, and two numbers");
                st = Console.ReadLine();
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }
            string stx = st.Substring(st.Length - x, x);
            string sty = st.Substring(0, y);
            string stm = st.Substring(y, st.Length - x - y);
            return (stx + stm + sty);
        }

        /*

        Question 3 - 
        Write a method that will receive a string as a parameter and delete all the substrings abc from it. The method will return a string after downloading the substrings. 
        For example: if the given string contains:ababcxyzabcdabacy then the returned string will be: abxyzdabacy.

        */

        public static string ABC(string st)
        {
            Console.WriteLine("Enter string");
            st = Console.ReadLine();
            string st1 = "";
            for (int i = 0; i < st.Length - 2; i++)
            {
                if (st[i] == 'a' && st[i + 1] == 'b' && st[i + 2] == 'c')
                    i += 2;
                else
                {
                    if (i == st.Length - 3)
                    {
                        st1 += st[st.Length - 3];
                        st1 += st[st.Length - 2];
                        st1 += st[st.Length - 1];
                        break;
                    }
                    st1 += st[i];
                }
            }
            return st1;
        }

        /*

        Question 4 - 
        Write a method that will receive a string as a parameter and return a new string that is the concatenation of the original string with its mirror image. 
        For example, if you record the string RETRO, then the string RETROORTER will be returned.

        */

        public static string Miror(string st)
        {
            Console.WriteLine("Enter string");
            st = Console.ReadLine();
            string st1 = st;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                st1 += st[i];
            }
            return st1;
        }

        /*

        Question 5 - 
        Write a method that will receive as a string parameter that consists of a sequence of different letters that can repeat themselves in the string. 
        The method will build and return a new string that shrinks the letters to a digit, letter, digit, letter... 
        Assume that the maximum number of characters for any character in a sequence is 9. Example: if the string is: CCCBBAAAAABBZ, the new string that will be obtained is: 3C2B5A2B1Z

        */

        public static string Row(string st)
        {
            Console.WriteLine("Enter string");
            st = Console.ReadLine();
            string st1 = "";
            int counter = 1;
            for (int i = 0; i < st.Length - 1; i++)
            {
                while (st[i] == st[i + 1])
                {
                    counter++;
                    i++;
                    if (i == st.Length - 1)
                        break;
                }
                st1 += counter;
                st1 += st[i];
                counter = 1;
            }
            if (st[st.Length - 1] != st[st.Length - 2])
            {
                st1 += '1';
                st1 += st[st.Length - 1];
            }
            return st1;
        }

        static void Main(string[] args)
        {
            string st = "";
            int x = 0, y = 0;
            Console.WriteLine(Kefel(st));          // Q1
            Console.WriteLine(Switch(st, x, y));   // Q2
            Console.WriteLine(ABC(st));            // Q3
            Console.WriteLine(Miror(st));          // Q4
            Console.WriteLine(Row(st));            // Q5

        }
    }
}