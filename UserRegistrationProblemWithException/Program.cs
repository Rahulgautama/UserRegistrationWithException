using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemWithException
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            try
            {
                Console.WriteLine("Please Enter your Mobile Number");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"^([\+]?[0-9]{1,3}[\s.-][0-9]{1,12})([\s.-]?[0-9]{1,4}?)$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Mobile Number");
                else
                    Console.WriteLine("Not Valid Mobile number");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valid Mobile Number");
            }
        }
    }
}
