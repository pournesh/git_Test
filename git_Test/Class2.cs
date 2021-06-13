using System;
using System.Collections.Generic;
using System.Text;

namespace git_Test
{
    class Class2 : Class1
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine(c.x.ToString() + "Hello World!");
        }
    }
}
