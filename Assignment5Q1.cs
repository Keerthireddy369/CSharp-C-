using Assignment5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
{
    public class Assignment5Q1
    {
        public static void Main()
        {


            int[] IntArr = new int[5];
            string[] StringArr = new string[5];

            {
                Console.WriteLine("Enter Elements into Integer Array:");
                for (int i = 0; i < IntArr.Length; i++)
                {
                    IntArr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter Elements into a String Array :");
                for (int j = 0; j < StringArr.Length; j++)
                {
                    StringArr[j] = Convert.ToString(Console.ReadLine());
                }
                void Print()
                {
                    Console.WriteLine("Please Select any of the number :");
                    Console.WriteLine("1.Copy");
                    Console.WriteLine("2.Sort");
                    Console.WriteLine("3.Clear");
                    Console.WriteLine("4.Reverse");
                    int k = Convert.ToInt32(Console.ReadLine());


                    if (k == 1)
                    {
                            
                           
                        try
                        {
                            Array.Copy(IntArr, StringArr, 5);
                        }
                        catch (ArrayTypeMismatchException e)
                        {
                            Console.WriteLine("Cannot copy due to : {0}", e);
                        }
                        finally
                        {
                            Print();
                        }
                       
                       
                    }
                    if (k == 2)
                    {

                        Console.WriteLine("After Sorting the Integer Array was :");
                        Array.Sort(IntArr);
                        foreach (int integer in IntArr)
                        {
                            Console.WriteLine(integer);
                        }
                        Console.WriteLine("After Sorting the String Array was :");
                        Array.Sort(StringArr);
                        foreach (string str in StringArr)
                        {
                            Console.WriteLine(str);
                        }
                        Print();
                    }

                    if (k == 3)
                    {
                        Console.WriteLine("After Clearing the Integer Array was :");
                        Array.Clear(IntArr,0,2);
                        foreach (int integer in IntArr)
                        {
                            Console.WriteLine(integer);
                        }
                        Console.WriteLine("After Clearing String Array was:");
                        Array.Clear(StringArr, 0, 2);
                        foreach(String str in StringArr)
                        { 
                            Console.WriteLine(str); 
                        }
                        Print();
                    }
                    if (k == 4)
                    {
                        Console.WriteLine("The Integer Array After Reversing was:");
                        Array.Reverse(IntArr);
                        foreach (int integer in IntArr)
                        {
                            Console.WriteLine(integer);
                        }
                        Console.WriteLine("The String Array After Reversing was:");
                        Array.Reverse(StringArr);
                        foreach (string str in StringArr)
                        {
                            Console.WriteLine(str);
                        }
                        Print();

                    }
                    Console.ReadLine();


                }
                Print();
            }

        }
    }
}


