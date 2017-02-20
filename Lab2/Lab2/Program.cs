using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2
{
    class Program
    {
        static void Main(string[] argv)
        {
            try
            {
                StreamReader src = new StreamReader(@"..\..\..\..\Data\Input.txt");
                while (src.Peek() != -1)
                {
                    string result = Regex.Replace(src.ReadLine(), @"([.?!])", "$0\n");
                    Console.WriteLine(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
