using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAffairsDigitalIdentityProcessor
{
    internal class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        
        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
        }

        // Calculat thee age based on the ID number (first 6 digits represent birth date in YYMMDD format)
        private int CalculateAge(string idNumber)
        {
            if (string.IsNullOrEmpty(idNumber) || idNumber.Length < 6)
                return 0;

            try
            {
                
                string birthDatePart = idNumber.Substring(0, 6);
                int year = int.Parse(birthDatePart.Substring(0, 2));
                int month = int.Parse(birthDatePart.Substring(2, 2));
                int day = int.Parse(birthDatePart.Substring(4, 2));

                
                int currentYear = DateTime.Now.Year;
                int currentTwoDigitYear = currentYear % 100;
                int birthYear;

                if (year <= currentTwoDigitYear)
                {
                    birthYear = 2000 + year;
                }
                else
                {
                    birthYear = 1900 + year;
                }

                
                DateTime birthDate = new DateTime(birthYear, month, day);

                
                int age = currentYear - birthYear;
                if (DateTime.Now < birthDate.AddYears(age))
                {
                    age--;
                }

                return age;
            }
            catch
            {
                return 0; 
            }
        }

        // Validate ID number
        public string ValidateID()
        {
            
            if (IDNumber.Length != 13)
            {
                return "Oops! That ID isn’t valid. It should be 13 digits long.";
            }

           
            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                {
                    return "Oops! That ID isn’t valid. Use numbers only, please.";
                }
            }

            // Check if age is valid (between 0 and 120)
            if (Age < 0 || Age > 120)
            {
                return "Invalid entry. The birth date from the ID is not valid.";
            }

            return "Great! Your ID number looks correctly formatted.";
        }

        // Generate profile summary
        public string ProfileSummary(string validationResult)
        {
            string profileSummary = "=== DIGITAL CITIZEN PROFILE ===\r\n";
            profileSummary += $"Full Name: {FullName}\r\n";
            profileSummary += $"ID Number: {IDNumber}\r\n";
            profileSummary += $"Age: {Age} years\r\n";
            profileSummary += $"Citizenship Status: {CitizenshipStatus}\r\n";
            profileSummary += $"Validation Result: {validationResult}\r\n";
            profileSummary += $"Profile Generated: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n";
            profileSummary += "=================================";

            return profileSummary;
        }
    }
}
