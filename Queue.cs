using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class Queues

    {
        public static void Main()
        {
            Queue que = new Queue();
            que.Enqueue("My_queue");
            que.Enqueue("123");
            que.Enqueue("lii234");
            Console.WriteLine("Total number of Elements are : {0} ", que.Count);
            Console.WriteLine("Elements in the queue was");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
