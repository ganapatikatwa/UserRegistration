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
    }
}
