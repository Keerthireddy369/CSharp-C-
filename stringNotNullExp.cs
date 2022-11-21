using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp
{
    internal class StringExp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            try
            {
                if (String.IsNullOrEmpty(name))

                    throw new Exception("String cannot be null");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);


            }
            finally { Console.WriteLine("Your name is : {0}", name); }
            Console.ReadKey();
        }
    }
}
