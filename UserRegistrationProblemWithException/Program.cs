using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemWithException
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Please Enter your Last Name With first char cap and min 3 len");
            try
            {
                var firstName = Console.ReadLine();
                var regexDt = new Regex("^[A-Z][a-zA-Z]{2,20}$");

                if (regexDt.IsMatch(firstName))
                    Console.WriteLine("Valid Last Name");
                else
                    Console.WriteLine("Last Name not valid");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valid Name");
            }
        }
    }
}
