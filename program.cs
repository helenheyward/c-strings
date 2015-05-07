using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "That day, life felt good and everlasting";
            
            myString = myString.Replace(" ", "--");
            
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
