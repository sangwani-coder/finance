using System;

namespace SkoolpayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Skoolpay!");

            // Prompt for student details
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter student grade: ");
            string studentGrade = Console.ReadLine();

            Console.Write("Enter contact information: ");
            string contactInfo = Console.ReadLine();

            // Prompt for payment details
            Console.Write("Enter payment amount: ");
            decimal paymentAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter payment date: ");
            DateTime paymentDate = Convert.ToDateTime(Console.ReadLine());

            // Display entered information
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Contact Information: {contactInfo}");

            Console.WriteLine("\nPayment Details:");
            Console.WriteLine($"Amount: {paymentAmount:C}");
            Console.WriteLine($"Date: {paymentDate:d}");

            // Wait for user input before closing the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}