using System;

namespace Class_Student_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Adrian = new Student(20, "Adrian");
            Console.WriteLine(Adrian.Info);
            Student Ion = new Student(20, "Ion");
            Student Vlad = new Student(24, "Vlad");
            Student George = new Student(22, "George");
            Student Daniel = new Student(21, "Daniel");
            Console.WriteLine(Ion.Info);
            Console.WriteLine(Vlad.Info);
            Console.WriteLine(George.Info);
            Console.WriteLine(Daniel.Info);
            Console.WriteLine("Nota lui Daniel este : ");
            Daniel.Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota lui Vlad este : ");         
            Vlad.Mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota lui Ion este : ");
            Ion.Mark = Convert.ToInt32(Console.ReadLine());
            Student[] studentMarks = { Daniel, Vlad, Ion };
            foreach (Student item in studentMarks)
            {
                Console.WriteLine("Media notelor celor doi este : " + item.GetAverageMark((double)Daniel.Mark,(double) Vlad.Mark,(double)Ion.Mark));
                break;
            }
        }
    }
}

