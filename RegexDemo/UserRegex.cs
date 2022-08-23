using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class UserRegex

    { public void LastName()
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
    }
}
