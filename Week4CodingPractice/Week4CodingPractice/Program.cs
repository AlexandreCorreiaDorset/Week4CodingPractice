using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4CodingPractice
{
    class Program
    {

        static string Ex1_StringExchange(string s)
        {
            string ret = "";
            for (int i = 0; i < s.Length; i++)
            {
                ret = ret + s[s.Length - 1 - i];
            }

            return (ret);
        }


        static bool Ex2_CheckSequence(int[] tab1, int[] tab2)
        {
            //We will check if tab1 is found in tab2. If one of the arrays are empty/null or if tab1 is bigger, we will return false
            bool ret = false;   //return bool

            if (tab1 == null || tab2 == null || tab1.Length == 0 || tab2.Length == 0 || tab1.Length > tab2.Length)
            {
                ret = false;
                return (ret);
            }
            else
            {
                for (int i = 0; i < tab2.Length - tab1.Length; i++)
                {
                    bool test = true;
                    for (int j = i; j < tab1.Length; j++)
                    {
                        if (tab2[j] != tab1[j - i])
                        {
                            test = false;
                        }
                    }

                    if (test)   //occurs if we found a perfect matching sequence
                    {
                        ret = true; //return becomes true
                    }
                }

                return (ret);
            }
        }


        static void Ex3A_PrintASCIIValue(char c)
        {
            Console.WriteLine("ASCII value of " + c + " is : " + (int)c);
        }

        static char[] Ex3_StringToSortedArrayOfChars(string s)
        {
            char[] tab = new char[s.Length];

            //Fill the array
            for (int i = 0; i < s.Length; i++)
            {
                tab[i] = s[i];
            }

            //Sort the array (bubble sort)

            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = 0; j < s.Length-1; j++)
                {
                    if ((int)tab[j] < (int)tab[j + 1])
                    {
                        char stock = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = stock;
                    }
                }
            }

            return (tab);
        }

        static string Ex4_CompressString(string s)
        {
            string s_ret = "";
            int i = 0;

            while (i < s.Length)
            {
                char stock = s[i];
                int k = 1;  //how many ?
                if (i < s.Length-1)
                {
                    while (s[i + 1] == s[i])
                    {
                        k++;
                        i++;
                    }
                }
                
                s_ret = s_ret + stock;
                s_ret = s_ret + Convert.ToChar(Convert.ToString(k));
                i++;
            }

            return (s_ret);
        }

        static void Ex5_PrintArmstrongNumbers_0_999()
        {
            int k = 1;
            for (int i = 0; i < 1000; i++)
            {
                string s = Convert.ToString(i);
                double c = 0;
                //Build of the cubic sum
                for (int j = 0; j < s.Length; j++)
                {
                    c = c + Math.Pow(Convert.ToInt32(Convert.ToString(s[j])),3);
                }

                if (i == c)
                {
                    Console.WriteLine("Armstrong Number " + k + ": " + i);
                    k++;
                }
               
            }
        }
            
        static void Ex6_CountNumberOfEachElementInArray(int[] tab)
        {
            //We will create two arrays: one that will record the found numbers, and one that will record, at the same position in array, the number of times we found it
            int[] tab_number = new int[tab.Length];
            int[] tab_frequence = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {

            }

        }

        static void Main(string[] args)
        {
            int[] tab = { 2, 8, 7, 0, 7, 8, 1, 8, 9 };
            Ex6_CountNumberOfEachElementInArray(tab);





            Console.ReadKey();
        }
    }
}
