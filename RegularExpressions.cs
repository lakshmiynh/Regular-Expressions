using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RgularExpression
{
    class RegularExpressions
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your First Name");
            string firstname=Console.ReadLine();

            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Check if the name matches the pattern
            if( Regex.IsMatch(firstname, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("please enter the valid name");
            }
        }
    }
}
