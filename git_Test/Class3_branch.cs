using System;
using System.Collections.Generic;
using System.Text;

namespace git_Test
{
    class Class3_branch : Class2
    {
        static void Main(string[] args)
        {
            Class3_branch c = new Class3_branch();
            Console.WriteLine(c.x.ToString() + "Hello World!");
            Console.WriteLine(c.c.ToString() + "Hello sap!");

        }
    }
}
