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
                Console.WriteLine("Please Enter your Password min 8 digit upper,lower,number,special char");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Password ");
                else
                    Console.WriteLine("Not Valid password ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valid Password");
            }
        }
    }
}
