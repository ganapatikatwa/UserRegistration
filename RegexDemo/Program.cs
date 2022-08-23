using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(String[] args)
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
}