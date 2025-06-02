using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace C_Sharp_1
{


    struct MyStruct
    {
      public  int Raf;
        public string FirstName;
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
        //method with parameter default
        static void PrintMyName(string Name = "RRRRRRRRRRR")
        {
            Console.WriteLine("Rouabah Mohammed Rafik Function Print : Parameter = {0} \a",Name);
        }
        //overloading
        static void PrintMyName(string FM , string LN)
        {
            Console.WriteLine("Rouabah Mohammed Rafik Function Print : Parameter = \a" + FM + " " + LN); ;
        }

        static void Main(string[] args)
        {
            Console.Write("hello 10 + 20 = " + (10 + 20)); // dosn;t go to another line
            Console.Write("--- this is a new line of code using console.write()");

            Console.WriteLine("\nHi Im {0},  MY Age Is {1}", "rafik", 31); // Writeline gives you a new line after + {0} {1} , accepted as a parameter 

            // new Line
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \n Programing Advices:\n");
            //tab
            Console.WriteLine("tab:");
            Console.WriteLine("welcome to \t progrming advices \n");


            Console.WriteLine("single quotation \' - back slash \\ double quotation \" alert \a  ");

            // Varibales :: same as C++

            string MyName = "Rafik";
            Console.WriteLine("My Name=" + MyName);

            int X = 10; int Y = 20;
            Console.WriteLine("X+y= " + (X + Y));

            double DBL = 25.89D;
            char c = 'K';
            bool Mybool = false;

            var T = "time"; // must be initialised   // called Implicitly types varibales

            /* Rules Of Naming Varibles in C#

             its like c++ the new is : 
            A varibale can star with @  like :    int @Rafik = 10 ;

            C# is case sensetive LOWER or Upper is different 

            auto = var

            */

            System.Int32 RaFik = 10;

            //byte in c#        

            byte b = 255; // 0 to 255

            sbyte sb = -128; // -128 to 127

            Console.WriteLine("\nByte: ");
            Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);

            Console.WriteLine("SByte: ");
            Console.WriteLine("Min={0} , Max ={1}", SByte.MinValue, SByte.MaxValue);

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


            MyDynamicVar = default(bool);
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            Nullable<int> nulab = null;
            Console.WriteLine("Nullable Varible = "+ (nulab));


            // Anonymous Type : we can't change the first value // we have to create it using the operato "new"
            // Anonymous Type can enclude another anonymous varible

            var STD = new { ID = 20, FirstName = "Rafik", LastName = new { _HusbenName ="Rouabah" ,_birthName = "SM",Date = 25  } };

            Console.WriteLine("\nAnonymous: \n" + STD.ID + "\n" + STD.LastName._HusbenName);
            Console.WriteLine("\nAnonymous: can also print all \n" + STD);


            // structs : 
            MyStruct stRafik = new MyStruct();
            stRafik.Raf = 021321;
            stRafik.FirstName = "AFK";






            /// Time Date functions:
            /// 
            DateTime D1 = new DateTime(); //= 01/01/0001 00:00:00
            DateTime D2 = new DateTime(1995, 01, 20); 
            DateTime D3 = new DateTime(1995, 1, 20, 13, 20, 30,90, DateTimeKind.Utc);
           

            DateTime dnow = DateTime.Now;

            Console.WriteLine(D1);
            Console.WriteLine(D2);
            
            Console.WriteLine(D3);  
            Console.WriteLine(dnow);

            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);


            TimeSpan Result = D2.Subtract(dnow);
            Console.WriteLine(Result);

            // we can use operators to do add substruct or logical 

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True




            var Dts1 = "06/12/2023";
            var Dts2 = "06.12.2023";
            var Dts3 = "33/12/2023";

            DateTime XXX = new DateTime();

            var IsValideDate = DateTime.TryParse(Dts3, out XXX);

            if (IsValideDate)
            {
                Console.WriteLine(XXX);
            }
            else
            {
                Console.WriteLine($" \n {Dts3} is not a valid Date string");
            }

            string SS1 = "Rouabah Mohammed RXfik";
            Console.WriteLine(SS1.Length);
            Console.WriteLine(SS1.ToLower());
            Console.WriteLine(SS1.ToUpper());
            Console.WriteLine(SS1[19]);
            Console.WriteLine(SS1.Insert(17,"--"));
            Console.WriteLine(SS1.Replace("X", "a"));
            Console.WriteLine(SS1.IndexOf("m"));
            Console.WriteLine(SS1.Contains("m"));
            Console.WriteLine(SS1.LastIndexOf("m"));

            //forming arr with split
            string S2 = "Rafik,Swatch,Polina";

            string[] NameArr = S2.Split(',');
            Console.WriteLine(NameArr[0]);
            Console.WriteLine(NameArr[1]);
            Console.WriteLine(NameArr[2]);

            string S3 = " Rafik ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimEnd());
            Console.WriteLine(S3.TrimStart());


            // string interpolation
            string firstName = "Rouabah";
            string lastName = "Rafik";
            string Code = "107";

            string FullName = $"Mr, {firstName} {lastName}, Code: {Code}";

            Console.WriteLine(FullName);

            // casting : 
            // from smaller data type to bigger it's automatiquly 
                           //we call that implicit casting     ضمني تحويل   
            int myint = 32;
            double Dbl =  myint; // Ok 

            // from larger size type to a smaller  :: called  explicit casting   صريح تحويل    
            double mydbl = 10.5d;
            int x = (int)mydbl;
            // int x = mydbl ; // error  
            Console.WriteLine(x); // = 10 

            int Z = Convert.ToInt32(mydbl);
            Console.WriteLine("using :  int Z = Convert.ToInt32(mydbl) : ");
            Console.WriteLine(Z);


            // casting enum to it's underlying integral type
            Console.WriteLine(enWeekDays.Friday);
            int WD = (int) enWeekDays.Friday;
            int WD1 = Convert.ToInt16(enWeekDays.Wednesday);
            Console.WriteLine($"F: {WD}, W: {WD1}.");

            enWeekDays enWKD = (enWeekDays)6;
            Console.WriteLine(enWKD);

            // readLine 
            Console.WriteLine("Enter A String: ");
            string @ReadLine = Console.ReadLine();
            Console.WriteLine(@ReadLine);   

            int RD = Convert.ToInt32(@ReadLine);

            Console.WriteLine($" iint input = {RD}");


            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++)); // print than add 1
            Console.WriteLine((number));

            Console.WriteLine((++number)); // add1 before print
            Console.WriteLine((number));


            for (int zz = 1; zz <= 5; ++zz)
            {

                if (zz == 3)
                {
                    continue;
                }

                Console.WriteLine(zz);
            }

            int[] Numbs = new int[6] { 01, 11, 111, 11, 11, 455 };


            /* Or we do that 
             * 
            numbs[0] = 10;
            numbs[1] = 11;  
            numbs[2] = 12;
            numbs[3] = 13;
            numbs[4] = 14;
            numbs[5] = 15;
           */


            for (int i = 0; i < 6; ++i)
            {
                Console.WriteLine($"\n // Number [{i}] = {Numbs[i]}");
            }


            Console.WriteLine("2nd Array[]");

            int[] array = { 45, 12, 212, 1235, 21254, 70007 };

            for (int j = 0; j < 6; ++j)
            {
                Console.WriteLine($"\n // Number [{j}] = {array[j]}");
            }

            Console.WriteLine("_2D Array : ");

            int[,] _2Darray = new int[2, 3]
            
            { { 1, 2, 3 }, { 4, 5, 6 } };


            for (int H = 0; H < 2; H++)
            {
                for (int K = 0; K<3;K++)
                {
                    Console.WriteLine(_2Darray[H,K]);
                }
            }

            Console.WriteLine("Foreach loop :");

            foreach (var cX in _2Darray)
            {
                Console.WriteLine(cX);
            }

            // min and max by using system.Link;

            array.Min();
            array.Max();

            array.Count();
            array.Average();
            array.Sum();


            // C MATH 

            int Mth = 65;
            int Mth2 = 35;

            Console.WriteLine("Max : {0}", Math.Max(Mth, Mth2));
            Console.WriteLine("Min : {0}",Math.Min(Mth, Mth2));
            Console.WriteLine("Sqrt(4) : {0}",Math.Sqrt(4));
            Console.WriteLine("5 Pow 2 : {0}",Math.Pow(5, 2));


            PrintMyName();
            PrintMyName(Name: "XXXXXXXXX");
            PrintMyName(FM: "Rouabah", LN: "Med Rafik");

            Console.ReadKey();
        }
    }
}
