using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RgularExpression
{
    public class RegularExpressions
    {
        public string pattern = @"^[A-Z][a-zA-Z]{2,}$";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            string lastname = Console.ReadLine();

            // Create an instance of RegularExpressions
            RegularExpressions regex = new RegularExpressions();

            // Call validation method for both first and last name
            regex.Validation(firstname);
            regex.Validation(lastname);
        }

        // Changed method to non-static
        public void Validation(string name)
        {
            // Access the pattern through instance variable
            if (Regex.IsMatch(name, this.pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Please enter a valid name");
            }
        }

    }  
        
    
}
