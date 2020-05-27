using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
                System.Console.WriteLine(i);
            Student s = new Student { Name = "Alex", Lastname = "Klar" };
            System.Console.WriteLine(s.Name);
            System.Console.WriteLine(s.Lastname);
            Student student2 = new Student { Name = "Vasya", Lastname = "Lomachenko" };
            Console.WriteLine("Hello world!!!");
        }
    }
}
