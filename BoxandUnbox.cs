using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class BoxandUnbox
    {
        public static void Main()
        {
            //BOXING
            int num = 123;
            Object obj = num;
            Console.WriteLine("Boxing");
            Console.WriteLine(num);
            Console.WriteLine(obj);
            //UNBOXING
            Console.WriteLine("Unboxing");
            Object obj2 = num;
            int num1 = (int)obj;
            Console.WriteLine(num1);
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
