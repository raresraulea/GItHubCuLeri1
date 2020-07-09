using System;

namespace GItHubCuLeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student s = new Student();
            Console.WriteLine(s.GetAge());

            Student s1 = new Student(12);
            Console.WriteLine(s1.GetAge());
        }
    }
}
