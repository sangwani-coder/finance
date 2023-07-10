using System;
//using System.Data.SQLite;
using System.IO;

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

            // Save student data to file
            string filePath = $"{studentName}"+"_receipt.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Student Details:");
                writer.WriteLine($"Name: {studentName}");
                writer.WriteLine($"Grade: {studentGrade}");
                writer.WriteLine($"Contact Information: {contactInfo}");

                writer.WriteLine("\nPayment Details:");
                writer.WriteLine($"Amount: {paymentAmount:C}");
                writer.WriteLine($"Date: {paymentDate:d}");
            }

            Console.WriteLine($"Student data saved to file: {filePath}");

            // Wait for user input before closing the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
