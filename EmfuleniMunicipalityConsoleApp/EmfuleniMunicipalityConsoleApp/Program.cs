using EmfuleniMunicipalityConsoleApp;
using System;
using System.Collections.Generic;

namespace EmfuleniMunicipalityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== WELCOME TO EMFULENI MUNICIPALITY SERVICE MANAGEMENT DESK ===");
            Console.WriteLine();

            List<Resident> residents = new List<Resident>();
            UtilitiesManager manager = new UtilitiesManager();

            // Resident data entry
            Console.Write("Enter number of residents: ");
            int residentCount;
            while (!int.TryParse(Console.ReadLine(), out residentCount) || residentCount <= 0)
            {
                Console.Write("Input not valid. Kindly enter a positive number: ");
            }

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n--- Resident {i + 1} Details ---");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                string accountNum = Console.ReadLine();

                Console.Write("Monthly Utility Usage (kWh): ");
                double usage;
                while (!double.TryParse(Console.ReadLine(), out usage) || usage < 0)
                {
                    Console.Write("Input not valid. Kindly enter a proper usage amount: ");
                }

                residents.Add(new Resident(name, address, accountNum, usage));
            }

            // 
            Console.Write("\nEnter number of service requests: ");
            int requestCount;
            while (!int.TryParse(Console.ReadLine(), out requestCount) || requestCount <= 0)
            {
                Console.Write("Invalid value. Kindly enter a positive number: ");
            }

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");

                // Select resident
                Console.WriteLine("Select Resident:");
                for (int j = 0; j < residents.Count; j++)
                {
                    Console.WriteLine($"  [{j + 1}] {residents[j].Name}");
                }

                int residentIndex;
                while (!int.TryParse(Console.ReadLine(), out residentIndex) || residentIndex < 1 || residentIndex > residents.Count)
                {
                    Console.Write($"Select valid resident (1-{residents.Count}): ");
                }
                Resident selectedResident = residents[residentIndex - 1];

                Console.Write("Request Type (e.g., Water Leak, Sewage, Electricity): ");
                string requestType = Console.ReadLine();

                Console.Write("Priority Level (1 = Lowest to 5 = Highest): ");
                int priority;
                while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
                {
                    Console.Write("Enter priority (1-5): ");
                }

                Console.Write("Severity Level (1 = Lowest to 10 = Highest): ");
                int severity;
                while (!int.TryParse(Console.ReadLine(), out severity) || severity < 1 || severity > 10)
                {
                    Console.Write("Enter severity (1-10): ");
                }

                Console.Write("Estimated Resolution Hours: ");
                int hours;
                while (!int.TryParse(Console.ReadLine(), out hours) || hours <= 0)
                {
                    Console.Write("Enter valid hours: ");
                }

                ServiceRequest request = new ServiceRequest(selectedResident, requestType, priority, severity, hours);
                manager.AddServiceRequest(request);
            }

            // Display and process requests
            bool continueProcessing = true;
            while (continueProcessing && manager.HasPendingRequests())
            {
                manager.DisplayQueue();

                Console.Write("\nEnter request number to process (0 to exit): ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Enter valid number: ");
                }

                if (choice == 0)
                {
                    continueProcessing = false;
                }
                else
                {
                    ServiceRequest processed = manager.ProcessRequest(choice - 1);
                    if (processed != null)
                    {
                        manager.GenerateProcessingReport(processed);
                    }
                    else
                    {
                        Console.WriteLine("Oops! That option isn’t valid. Try again.");
                    }
                }

                if (manager.HasPendingRequests() && continueProcessing)
                {
                    Console.Write("\nProcess another request? (Y/N): ");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y")
                    {
                        continueProcessing = false;
                    }
                }
            }

            // The summary report provides an overview of all processed requests, including the total number of requests, average urgency score and a breakdown of request types.
            manager.CreateSummaryReport();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}