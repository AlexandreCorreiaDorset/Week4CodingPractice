using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4CodingPractice
{
    class Program
    {
        static void DisplayArray(int[] tab)
        {
            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }

        static void DisplayArray(char[] tab)
        {
            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }

        static void DisplayArray(Person[] tab)
        {
            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i].Name + " ");
            }
            Console.WriteLine();
        }

        static int[] EnterArray()
        {
            Console.WriteLine("Enter size of array");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter value for tab[" + i + "]");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            return (tab);
        }


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
            List<int> l = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (!l.Contains(tab[i]))
                {
                    int k = 0;
                    for (int j = 0; j < tab.Length; j++)
                    {
                        if (tab[i] == tab[j])
                        {
                            k++;
                        }
                    }
                    Console.WriteLine(tab[i] + " appears " + k + " times in the array");
                    l.Add(tab[i]);
                }
                
            }
        }

        static int Ex7_Factorial(int r)
        {
            int ret = 0;
            //If negative number, we will return -1
            if (r < 0)
            {
                ret = -1;
            }
            else
            {
                if (r == 0)
                {
                    ret = 1;
                }
                else
                {
                    ret = 1;
                    for (int i = 1; i <= r; i++)
                    {
                        ret = ret * i;
                    }
                }
            }

            return (ret);

        }

        static int Ex8_NumberOfWhiteSpaces(string s)
        {
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    k++;
                }
            }
            return (k);
        }

        static Person[] Ex9_Person_Array()
        {
            Console.WriteLine("Enter name of first person");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter name of second person");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter name of third person");
            string s3 = Console.ReadLine();

            Person p1 = new Person(s1);
            Person p2 = new Person(s2);
            Person p3 = new Person(s3);

            Person[] tab = new Person[3];
            tab[0] = p1;
            tab[1] = p2;
            tab[2] = p3;

            return (tab);
        }

        static void Main(string[] args)
        { 
            bool exit = false;
            while (!exit)
            {
                #region texte
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Coding Practice 4th October 2022");
                Console.WriteLine("Alexandre CORREIA");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("====================");
                Console.WriteLine("Enter exercise");
                Console.WriteLine("1 String exchange");
                Console.WriteLine("2 Check sequence");
                Console.WriteLine("3A Print ascii value");
                Console.WriteLine("3 String to sorted array of chars");
                Console.WriteLine("4 Compress string");
                Console.WriteLine("5 Print armstrong numbers");
                Console.WriteLine("6 Count number of elements in each array");
                Console.WriteLine("7 Factorial");
                Console.WriteLine("8 Number of white spaces");
                Console.WriteLine("9 Person array");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("enter END to leave program");
                Console.ForegroundColor = ConsoleColor.White;
                #endregion
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Enter a word");
                        string s = Console.ReadLine();
                        Console.WriteLine(Ex1_StringExchange(s));
                        break;

                    case "2":
                        Console.WriteLine("Enter the sequence we will be searching");
                        int[] tab1 = EnterArray();
                        Console.WriteLine("Enter the greater sequence in which we will search the first sequence");
                        int[] tab2 = EnterArray();

                        Console.WriteLine("Is the sequence found? " + Ex2_CheckSequence(tab1, tab2));
                        break;

                    case "3A":
                        Console.WriteLine("Enter a char");
                        char c = Convert.ToChar(Console.ReadLine());
                        Ex3A_PrintASCIIValue(c);
                        break;

                    case "3":
                        Console.WriteLine("Enter a string");
                        string s2 = Console.ReadLine();
                        char[] tab_char = Ex3_StringToSortedArrayOfChars(s2);
                        DisplayArray(tab_char);
                        break;

                    case "4":
                        Console.WriteLine("Enter a string");
                        string s3 = Console.ReadLine();
                        Console.WriteLine(Ex4_CompressString(s3));
                        break;

                    case "5":
                        Ex5_PrintArmstrongNumbers_0_999();
                        break;

                    case "6":
                        int[] tab = EnterArray();
                        Ex6_CountNumberOfEachElementInArray(tab);
                        break;

                    case "7":
                        Console.WriteLine("Enter an integer");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Ex7_Factorial(n));
                        break;

                    case "8":
                        Console.WriteLine("Enter a string");
                        string s4 = Console.ReadLine();
                        Console.WriteLine("Number of white spaces: " + Ex8_NumberOfWhiteSpaces(s4));
                        break;

                    case "9":
                        Person[] p_tab = Ex9_Person_Array();
                        Console.WriteLine();
                        Console.WriteLine("The array : ");
                        DisplayArray(p_tab);

                        break;

                    case "END":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("This is not valid");
                        break;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter a key to continue...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
            




            
        }
    }
}
