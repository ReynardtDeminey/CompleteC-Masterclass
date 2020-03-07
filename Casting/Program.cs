using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 10.59384;
            int myInt;

            myInt = (int)myDouble;
            int mySecondInt = Convert.ToInt32(myDouble);
            string myString = Convert.ToString(myDouble);

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine(mySecondInt);
            Console.WriteLine(myString);
        }
    }
}
