using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    //Types Of Method
    class MethodTypes
    {
        /// <summary>
        /// Non-Value Returning Method Without parameter
        /// </summary>
        public void Test1()                          /////Static In Behaviour
        {
            string name = "Santosh";
            Console.WriteLine("Non-Value Returning Method Without parameter" + " " + name.ToUpper());
        }
        /// <summary>
        /// Non-Value Returning Method With parameter
        /// </summary>
        /// <param name="name"></param>
        public void Test2(string name)              ////Dynamic In Behaviour
        {
            Console.WriteLine("Non-Value Returning Method with parameter" + " " + name.ToUpper());
        }
        /// <summary>
        /// Value Returning Method Without parameter
        /// </summary>
        /// <returns></returns>
        public string Test3()                      /////Static In Behaviour
        {
            string name = "Santosh";
            return name.ToUpper();
        }
        /// <summary>
        /// Value Returning Method With parameter
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Test4(string name)           ////Dynamic In Behaviour
        {
            return name.ToUpper();
        }
    }
}
