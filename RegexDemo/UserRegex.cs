using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class UserRegex

    { public void Password()
        {
            Console.WriteLine("Password Minimum 1 Upper Case");
            var data = Console.ReadLine();
            String namepattern = "^(?=.{8,}$)(?=.*[a-z])(?=.*[A-Z]).*$";
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
