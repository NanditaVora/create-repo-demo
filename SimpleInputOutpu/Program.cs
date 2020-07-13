using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInputOutput
{
    /*
     * this program teaches the learner
     *   to use Console.ReadLine() to read the input
     *   and print the same
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration -> Line Comment
            // datatype variable; -> Line Comment
            string username;
            Console.Write("Enter Your Name : ");
            username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
        }
    }
}
