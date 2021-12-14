using System; //framwork class ibraries---> classes and methods--> here using: keyword sys:ns
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFIRSTAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Write("Asalam o Alaikum");
              Console.WriteLine("Learning C#");*/

            int age ;
            string name;
float height;
            Console.WriteLine("Enter your name:"); //for printing on the screen
            name = Console.ReadLine(); // for taking input it is in string format
            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());
	    Console.WriteLine("Enter your height:");
            height= float.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name + " " + height);
            Console.Write("You are " + age + " years old");

           
        }
    }
}
