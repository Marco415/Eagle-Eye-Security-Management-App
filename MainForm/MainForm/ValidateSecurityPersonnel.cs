using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainForm
{
    
    internal class ValidateSecurityPersonnel
    {
        public string IsValidIDNumber(string idNumber)
        {
            // Check length
            if (idNumber.Length != 13)
            {
                return "ID must have a length of 13";
            }

            if (!ulong.TryParse(idNumber, out ulong _))
            {
                return "ID must only consist of digits";
            }

            // Extract the birthdate part (first 6 digits)
            string birthdatePart = idNumber.Substring(0, 6);

            // Determine century prefix based on age
            string centuryPrefix;
            int year = int.Parse(birthdatePart.Substring(0, 2));
            if (year <= DateTime.Now.Year % 100)
            {
                centuryPrefix = "20"; // 2000s
            }
            else
            {
                centuryPrefix = "19"; // 1900s
            }

            // Combine to form the full birthdate string
            string fullBirthdate = centuryPrefix + birthdatePart;

            // Try to parse the date
            DateTime birthDate;
            bool isValidDate = DateTime.TryParseExact(fullBirthdate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);

            // Check if the date is valid and not in the future
            if (!isValidDate)
            {
                return "ID birthdate is invalid.";
            }
            if (birthDate <= DateTime.Now)
                return "";
            else
                return "ID birthdate cannot be in the future.";

        }

        public string IsValidPhoneNumber(string phoneNumber)
        {
            // Remove any non-digit characters for example: 088-444-4444 -> 0884444444
            string cleanedPhoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

            // Check if it's a valid local phone number (10 digits starting with 0)
            return IsValidLocalPhoneNumber(cleanedPhoneNumber);
        }

        public string IsValidLocalPhoneNumber(string phoneNumber)
        {
            // Check if it is exactly 10 digits long
            if (phoneNumber.Length != 10)
            {
                return "Phone number must be 10 digits";
            }

            // Check if it starts with a valid digit (0 followed by 6, 7, or 8) and is entirely numeric
            if (Regex.IsMatch(phoneNumber, @"^0[678]\d{8}$"))
                return "";
            else
                return "Invalid Phone Number.\n1. It must only consist of digits \n2. It must begin with 0 and be followed by a 6, 7, or 8.";
        }

        public bool IsValidEmail(string email)
        {
            // Regular expression for validating an email address
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }

        public bool IsTxtEmpty(System.Windows.Forms.TextBox txt)
        {
            return (string.IsNullOrWhiteSpace(txt.Text));
        }
    }
}
