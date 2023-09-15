using System;

namespace ChapterThreeOperatorAndExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5 + 9;
            Console.WriteLine(a);
            int a = 5;
            int b = 7;
            Console.WriteLine(a + b);

            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);



            int x = 10, int= 5;
            Console.WriteLine("x> is" + (x > y));


            Console.WriteLine(DateTime.Now);

            int[] isArray = { 1, 2, 3, 4 };
            Console.WriteLine(isArray[0]);

            string str = "Hello";
            Console.WriteLine(str[1]);


            //implicit
            int myInt = 5;
            Console.WriteLine(myInt); 
            long myLong = myInt;
            Console.WriteLine(myLong);
            Console.WriteLine(myLong + myInt);

            //Explicit
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); 
            long myLong = (long)myDouble;
            Console.WriteLine(myLong);




            long myLong = long.MaxValue;
            Console.WriteLine(myLong);
            Console.WriteLine(myInt);


            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters; // Explicit

        }
    }
}

as new is
