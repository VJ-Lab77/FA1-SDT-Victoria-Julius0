using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipalityConsoleApp
{
    internal class UtilitiesManager
    {
        private List<ServiceRequest> pendingRequests;
        private List<ServiceRequest> processedRequests;

        public UtilitiesManager()
        {
            pendingRequests = new List<ServiceRequest>();
            processedRequests = new List<ServiceRequest>();
        }

        // The serviceRequest is added to the pending requests list and then sorted by urgency score
        public void AddServiceRequest(ServiceRequest request)
        {
            pendingRequests.Add(request);
            SortRequestsByUrgency();
        }

        // The sort method sorts the pending requests in descending order based on their urgency score ensuring that the most urgent requests are processed first.
        private void SortRequestsByUrgency()
        {
            pendingRequests = pendingRequests.OrderByDescending(r => r.UrgencyScore).ToList();
        }

        
        public bool HasPendingRequests()
        {
            return pendingRequests.Count > 0;
        }

        // Display queue with urgency scores
        public void DisplayQueue()
        {
            if (pendingRequests.Count == 0)
            {
                Console.WriteLine("No pending service requests.");
                return;
            }

            Console.WriteLine("\n=== PENDING SERVICE REQUESTS (Sorted by Urgency) ===");
            for (int i = 0; i < pendingRequests.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {pendingRequests[i]}");
                Console.WriteLine($"    Resident: {pendingRequests[i].Residents.Name}");
                Console.WriteLine($"    Resolution Time: {pendingRequests[i].EstimatedResolutionHours} hours");
                Console.WriteLine();
            }
        }

        // Process the request at the specified index, mark it as processed, move it to the processed list and return the processed request for reporting
        public ServiceRequest ProcessRequest(int index)
        {
            if (index < 0 || index >= pendingRequests.Count)
            {
                return null;
            }

            ServiceRequest request = pendingRequests[index];
            request.IsProcessed = true;
            pendingRequests.RemoveAt(index);
            processedRequests.Add(request);

            return request;
        }

        
        public void GenerateProcessingReport(ServiceRequest request)
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("SERVICE REQUEST PROCESSING REPORT");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"\n{request.Residents}");
            Console.WriteLine($"\nRequest Type: {request.RequestType}");
            Console.WriteLine($"Priority Level: {request.PriorityLevel}/5");
            Console.WriteLine($"Severity Level: {request.SeverityLevel}/10");
            Console.WriteLine($"Estimated Resolution: {request.EstimatedResolutionHours} hours");
            Console.WriteLine($"Urgency Score: {request.UrgencyScore}");
            Console.WriteLine($"Processed At: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine(new string('=', 50));
        }

        
        public void CreateSummaryReport()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("FINAL SUMMARY - ALL THE PROCESSED REQUESTS");
            Console.WriteLine(new string('=', 50));

            if (processedRequests.Count == 0)
            {
                Console.WriteLine("No requests were processed.");
                return;
            }

            ServiceRequest highestUrgency = processedRequests.OrderByDescending(r => r.UrgencyScore).First();

            Console.WriteLine($"\nThe Total Requests Processed: {processedRequests.Count}\n");

            Console.WriteLine("Resolved Requests:");
            foreach (var request in processedRequests)
            {
                Console.WriteLine($"  - {request.RequestType} for {request.Residents.Name} (Urgency: {request.UrgencyScore})");
            }

            Console.WriteLine($"\n*** THE HIGHEST URGENCY SCORE REQUEST ***");
            Console.WriteLine($"Request: {highestUrgency.RequestType}");
            Console.WriteLine($"Resident: {highestUrgency.Residents.Name}");
            Console.WriteLine($"Urgency Score: {highestUrgency.UrgencyScore}");

            Console.WriteLine(new string('=', 50));
        }
    }
}
