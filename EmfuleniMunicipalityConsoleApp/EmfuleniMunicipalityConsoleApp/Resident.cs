using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipalityConsoleApp
{
    internal class Resident
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUtilityUsage { get; set; }

        
        public Resident(string name, string address, string accountNumber, double monthlyUtilityUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUtilityUsage = monthlyUtilityUsage;
        }

        
        public override string ToString()
        {
            return $"Resident: {Name}\nAddress: {Address}\nAccount #: {AccountNumber}\nMonthly Usage: {MonthlyUtilityUsage} kWh";
        }
    }
}
