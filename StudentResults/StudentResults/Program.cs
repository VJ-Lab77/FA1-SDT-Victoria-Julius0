using System;

namespace StudentResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== STUDENT GRADE CALCULATOR ===");
            Console.WriteLine();

            // Prompt for student name
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            
            double[] marks = new double[3];
            string[] subjects = { "Subject 1", "Subject 2", "Subject 3" };

            
            for (int i = 0; i < 3; i++)
            {
                double mark;
                bool isValid = false;

                do
                {
                    Console.Write($"Enter {subjects[i]} Mark: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out mark))
                    {
                        if (mark >= 0 && mark <= 100)
                        {
                            marks[i] = mark;
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oops! Marks should be between 0 and 100. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oops! Please enter a valid number value.");
                    }
                } while (!isValid);
            }

            // Calculate total and average
            double total = marks[0] + marks[1] + marks[2];
            double average = total / 3;

            // Student PASSED or FAILED based on average
            string result = (average >= 50) ? "PASS" : "FAIL";

            // Display results
            Console.WriteLine();
            Console.WriteLine("=== STUDENT RESULTS ===");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Result: {result}");
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Result Issued At: {currentTime.ToString("yyyy-MM-dd HH:mm:ss")}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}