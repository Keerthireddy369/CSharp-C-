using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class ArrayLists

    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");   
            Console.WriteLine("Total Elements present in the list are : {0}",list.Count);
            Console.WriteLine("The Elements are :");
            foreach (var item in list)
            {
               
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}






