using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodTypes methodTypes = new MethodTypes();
            methodTypes.Test1();
            Console.WriteLine("Please Enter The Name");
            string name = Console.ReadLine();
            methodTypes.Test2(name);
            name=methodTypes.Test3();
            Console.WriteLine("The Length of the Given Name" + name + " " + "Is:" + " " + name.Length);
            Console.WriteLine("Please Enter The Name");
            name = Console.ReadLine();
            name= methodTypes.Test4(name);
            Console.WriteLine("The Lower Case Of Given Name " + name + " " + "Is:" + " " + name.ToLower());
            Console.ReadLine();
        }
    }
}
