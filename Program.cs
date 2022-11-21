using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Employee
    {
        public int ID = 123;
        public string Name = "Keerthi";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("ID : {0}", ID);
        }
    }
    class Officer : Employee
    {
        public String id = "123456789";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Officer Id : {0}", id);
        }
    }
}
class Test
{
    static void Main()
    {
        Officer OFF = new Officer();
        OFF.GetInfo();
        Console.ReadKey();
    }
  
}



