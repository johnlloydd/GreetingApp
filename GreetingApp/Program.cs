using System;
namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the total number of your enrolled courses: ");
            int courses;
            courses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of your favorite book: ");
            double book;
            book = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Enrolled courses: " + courses);
            Console.WriteLine("Price of my favorite books: " + book);
            Console.Write("\n Press any key top exit...");
            Console.ReadKey();

        }
    }
}