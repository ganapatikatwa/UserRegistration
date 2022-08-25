using System;
using System.Text.RegularExpressions;
using RegexDemo;


public class Program
{
    static void Main(String[] args)
    {
        UserRegex user = new UserRegex();

        bool n = true;
        while (n)
        {
            Console.WriteLine("Choose option 1. Firstname 2.Last Name 3.Email 4. mobile no 5.password" +
                "\n6.password With One upper case 7.password With One upper case and oneNumeric");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: user.Name(); break;
                case 2: user.LastName(); break;
                case 3: user.EMail(); break;
                case 4: user.PhoneNumber(); break;
                case 5: user.Password(); break;
                case 6: user.PasswordUpperCase(); break;
                case 7: user.PasswordUpperCaseNumber(); break;
                default:
                    n = false;
                    Console.WriteLine("Enter valid option"); break;
            }
        }
        


    }
}