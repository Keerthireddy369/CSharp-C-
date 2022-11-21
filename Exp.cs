using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class Exp
    {
        int result;

        Exp()
        {
            result = 0;

        }
        public void division (int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine("Exception Caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result : {0}", result);
            }
        }
        static void Main()
        {
            Exp exp = new Exp();
            exp.division(25, 0);
            Console.ReadKey();
        }
    }
}
