using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class UserRegex

    { public void PhoneNumber()
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
    }
}
