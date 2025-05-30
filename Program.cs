using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_Sharp_1
{


    struct MyStruct
    {
        int Raf;
        string FirstName;
    }


    //------------ enum-------------------
    enum enWeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    //if you set a value , it will auto number everything after it.
    enum enCategories
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }


    //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
    //but not string

    enum enCategories2 : byte
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15
    }
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

            //byte in c#        

            byte b = 255; // 0 to 255

            sbyte sb = -128; // -128 to 127

            Console.WriteLine("\nByte: ");
            Console.WriteLine("Min={0} , Max={1}",Byte.MinValue,Byte.MaxValue);

            Console.WriteLine("SByte: ");
            Console.WriteLine("Min={0} , Max ={1}",SByte.MinValue,SByte.MaxValue);

            // short = int16


            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'



            Nullable<int> @i_5 = null;


            //you dont specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value


            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); // system.Int32  MyDynamicVar = "Hello World!!";
           
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());


            Console.ReadKey();
        }
    }
}
