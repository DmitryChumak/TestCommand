using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // тип обучения 
    public enum Type_of_trening
    {
        stationary,
        semi_stationary,
        Remotely
    };
    class Program
    {
       
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
                System.Console.WriteLine(i);
            Student s = new Student { Name = "Alex", Lastname = "Klar", form_education = Type_of_trening.Remotely };
            System.Console.WriteLine(s.Name);
            System.Console.WriteLine(s.Lastname);
            Student student2 = new Student { Name = "Vasya", Lastname = "Lomachenko" , form_education = Type_of_trening.semi_stationary};
            Student student3 = new Student { Name = "Maрина", Lastname = "Ломаченко", form_education = Type_of_trening.stationary };
            Console.WriteLine("Hello world!!!");
            // вывожу масив студентов 
            Student[] students = { student2, student3, s };
            foreach (var i in students)
                Console.WriteLine(i.Name + " "+ i.Lastname +" "+ i.form_education);
          

        }
        




    }
}
