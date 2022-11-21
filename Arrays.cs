using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class Arrays
    {
        public static void Main()
        {
            int[] demo = new int[5];
            int i;
            for (i = 0; i < demo.Length; i++)
            {
                Console.WriteLine("Enter Value:");
                demo[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Elements in the array was :");


            for (i = 0; i < demo.Length; i++)
            {

                Console.WriteLine(demo[i]);

            }
            Console.WriteLine("Maximum number in the array was :{0}", demo.Max());
            Console.WriteLine("Minimum number in the array was : {0}", demo.Min());
            Console.WriteLine("Sum of the numbers in the array was : {0}", demo.Sum());

                Console.ReadKey();
            
        }
    }
}
