using System;
using System.Text.RegularExpressions;  // 100/100
class Program
{
    static void Main()
    {
        Regex pattern = new Regex(@"^[^\s_.]{3}$|^[^\s_.]{3}(.[^\s_.]{3})*$");

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "ReadMe")
        {
            if (pattern.IsMatch(input))
            {
                bool isPalindrome = true;

                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (char.ToLower(input[i]) != char.ToLower(input[input.Length - 1 - i]))
                    {
                        Console.WriteLine("NO");
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}