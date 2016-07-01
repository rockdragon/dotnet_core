using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<String>();
            list.Add("hello");
            list.Add("World");

            Console.WriteLine("Hello World! length is {0}",
                list.Count);
        }
    }
}
