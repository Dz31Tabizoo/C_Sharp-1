using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello 10 + 20 = " + (10 + 20)); // dosn;t go to another line
            Console.WriteLine("\nHi Im {0}  MY Age Is {1}", "rafik", 31); // Writeline gives you a new line after + {0} {1} , accepted as a parameter 

            // new Line
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \n Programing Advices:\n" );
            //tab
            Console.WriteLine("tab:");
            Console.WriteLine("welcome to \t progrming advices \n");


            Console.WriteLine("single quotation \' - back slash \\ double quotation \" alert \a  ");

            // Varibales :: same as C++

             string MyName = "Rafik";
            Console.WriteLine("My Name=" + (MyName));

            int X = 10; int y = 200;
            Console.WriteLine("X+y= " + (X, y));

            double DBL = 25.89D;
            char c = 'K';

            bool Mybool = false;

            var T = "time";

            /* Rules Of Naming Varibles in C#

             its like c++ the new is : 
            A varibale can star with @  like :    int @Rafik = 10 ;

            C# is case sensetive LOWER or Upper is different 

            auto = var

            */
            System.Int32 RQFF = 10;

            DateTime.Now 



           


            Console.ReadKey();
        }
    }
}
