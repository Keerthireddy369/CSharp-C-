using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    public class MyStack : ICloneable
    {
        public object Clone()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            
            Console.WriteLine("Elements in the stack are :");
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            return stack;

        }

    }
    public class program
    {
        public static void Main()
        {
            MyStack stack = new MyStack();
            stack.Clone();
            Stack arr = new Stack();
            arr = (Stack)stack.Clone();
            Console.WriteLine("cloned stack array was :");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadKey();
        }
    }

    
}
