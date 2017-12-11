using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = new string(input.Reverse().ToArray());
        Console.WriteLine(result);
    }
}
