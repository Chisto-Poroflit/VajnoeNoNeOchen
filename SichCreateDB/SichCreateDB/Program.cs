using DbLibrary;
using System;

namespace SichCreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationContext())
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
