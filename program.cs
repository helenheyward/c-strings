using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you run this code the spaces inbetween the words will be replaced by two dashes

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "I'm learning how to push it with Try Git!  http://bit.ly/TryGit via @codeschool";
            
            myString = myString.Replace(" ", "--");
            
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
