using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    interface IRectangle
    {
        void Detais(int l, int b);
    }
    class Data : IRectangle
    {
        public void Detais(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area = {0}", area);

        }
    }
    class program
    {
        public static void Main()
        {
            Data data = new Data();
            data.Detais(10, 20);
        }
    }
}
