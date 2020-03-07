using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {   
            string firstName = "Reynardt";
            string lastName = "Deminey";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName.Length);
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
        }
    }
}
