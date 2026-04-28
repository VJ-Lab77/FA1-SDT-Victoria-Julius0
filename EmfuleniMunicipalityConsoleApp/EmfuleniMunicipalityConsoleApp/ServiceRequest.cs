using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipalityConsoleApp
{
    internal class ServiceRequest
    {
        public Resident Residents { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }      // 1 to 5
        public int SeverityLevel { get; set; }      // 1 to 10
        public int EstimatedResolutionHours { get; set; }
        public int UrgencyScore { get; private set; }
        public bool IsProcessed { get; set; }

        
        public ServiceRequest(Resident resident, string requestType, int priority, int severity, int hours)
        {
            Residents = resident;
            RequestType = requestType;
            PriorityLevel = priority;
            SeverityLevel = severity;
            EstimatedResolutionHours = hours;
            IsProcessed = false;
            CalculateUrgencyScore();
        }

        
        public void CalculateUrgencyScore()
        {
            UrgencyScore = (int)((PriorityLevel * 2) + (SeverityLevel * 1.5));
        }

        public override string ToString()
        {
            return $"Request: {RequestType} | Urgency Score: {UrgencyScore} | Priority: {PriorityLevel} | Severity: {SeverityLevel}";
        }
    }
}
