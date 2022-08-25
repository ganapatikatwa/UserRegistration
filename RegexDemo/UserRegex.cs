using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class UserRegex

    {
        public void Name()
        {
        Console.WriteLine("Enter Name");
        var data = Console.ReadLine();
        String namepattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
        Regex regex = new Regex(namepattern);
        if (regex.IsMatch(data))
        {
            Console.WriteLine("Name is Valid");
        }
        else
        {
            Console.WriteLine("Name is not Valid");
        }
    }
        public void LastName()
        {
            Console.WriteLine("Last Name");
            var data = Console.ReadLine();
            String namepattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Last is Valid");
            }
            else
            {
                Console.WriteLine("Last is not Valid");
            }
        }

        public void EMail()
        {
            Console.WriteLine("e mail");
            var data = Console.ReadLine();
            String namepattern = "^[a-z]{3}[.]{1}([a-z]{3}){0,1}[@]{1}[a-z]{2}[.]{1}[a-z]{2,3}[.]{1}([a-z]{2}){0,1}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("e mail is Valid");
            }
            else
            {
                Console.WriteLine("e mail is not Valid");
            }
        }

        public void PhoneNumber()
        {
            Console.WriteLine("Phone Number");
            var data = Console.ReadLine();
            String namepattern = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Phone number is Valid");
            }
            else
            {
                Console.WriteLine("Phone number is not Valid");
            }
        }

        public void Password()
        {
            Console.WriteLine("Password");
            var data = Console.ReadLine();
            String namepattern = "^[a-zA-Z]{8,}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
            }
        }



        public void PasswordUpperCase()
        {
            Console.WriteLine("Password Minimum 1 Upper Case");
            var data = Console.ReadLine();
            String namepattern = "^(?=.*?[A-Z])[a-zA-Z]{8,}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
            }
        }

        public void PasswordUpperCaseNumber()
        {
            Console.WriteLine("Password Minimum 1 Upper Case 1 Numeric Case");
            var data = Console.ReadLine();
            String namepattern = "^(?=.*?\[d])(?=.*?[A-Z])[a-zA-Z]{8,}$";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
            }
        }
    }
}
