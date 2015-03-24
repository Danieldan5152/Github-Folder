using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace
namespace My_First_app
{
    // Class (contains funcionalty) 
    class Program
    {
        // Function(entry point)
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number, any number?");
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            if (keyinfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number! KNOCK IT OFF NOW!");
            }
            else
            {
                Console.WriteLine("Did you type {0}", keyinfo.KeyChar.ToString());
            }
        }
        /// <summary>
        /// all this function does is print foo to the screen
        /// </summary>
        static void PrintFooToScreen() 
        {
            Console.WriteLine("Foo)
        }

    }
}
