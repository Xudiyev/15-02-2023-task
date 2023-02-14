using System;

namespace _14_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();


            do
            {
                Console.WriteLine("GroupNo: ");
                string groupNo = Console.ReadLine();

                if (Student.CheckGroupNo(groupNo))
                {
                    student.GroupNo = groupNo;
                    break;
                }

            } while (true);

            do
            {
                Console.WriteLine("Age");
                int Age = Convert.ToInt32(Console.ReadLine());

                if (Age>=0)
                {
                    student.Age = Age;
                    break;
                }

            } while (true);

            //do
            //{
            //    Console.WriteLine("FullName: ");
            //    string FullName = Console.ReadLine();

            //} while (true);

            Console.WriteLine($"Student: {student.FullName}, GroupNo: {student.GroupNo}, Age: {student.Age}");
        }

        
    }
}
