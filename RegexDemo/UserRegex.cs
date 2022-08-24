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
            String namepattern = "^(?=.*[A-Z])[a-zA-Z]{8,}$";
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
