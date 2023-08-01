using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateEmail(string email)
    {
        
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        
        if (Regex.IsMatch(email, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Enter your email address: ");
        string userInput = Console.ReadLine();

        if (ValidateEmail(userInput))
        {
            Console.WriteLine("Valid email address");
        }
        else
        {
            Console.WriteLine("Invalid email address. Please enter a valid email address.");
        }
    }
}