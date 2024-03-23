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



        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your Last name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your phone number");
            string phoneno = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string password= Console.ReadLine();

            // Create an instance of RegularExpressions
            RegularExpressions regex = new RegularExpressions();

            // Call validation method for both first and last name
            regex.Validation(firstname);
            regex.Validation(lastname);
            regex.emailvalidation(email);
            regex.Validatephoneno(phoneno);
            regex.validatepassword(password);
        }

        
       public void Validation(string name)
        {

            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Please enter a valid name");
            }
        }

        public void emailvalidation(string email)
        {

            string mailpattern = @"^[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-zA-Z0-9]+\.)+[a-zA-Z]{2,}$";

            if (Regex.IsMatch(email, mailpattern))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Enter valid mailid");
            }
        }

        public void Validatephoneno(string phoneno)
        {
            string phonepattern = @"^\d{2}\s\d{10}$";

            if (Regex.IsMatch(phoneno, phonepattern))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Enter valid phone number");
            }
        }

        public void validatepassword(string password)
        {
            string passwordpattern = @"^(?=.* [A - Z])[A - Za - z]{ 8,}$";


            if (Regex.IsMatch(password,passwordpattern))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("please enter valid password");
            }

        }



    }  
        
    
}
