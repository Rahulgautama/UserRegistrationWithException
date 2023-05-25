using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemWithException
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Please Enter your first Name With first char cap and min 3 len");
            try
            {
                var firstName = Console.ReadLine();
                var regexDt = new Regex("^[A-Z][a-zA-Z]{2,20}$");

                if (regexDt.IsMatch(firstName))
                    Console.WriteLine("Valid First Name");
                else
                    Console.WriteLine("Not Valid First Name");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valid Name");
            }
        }
    }
}
