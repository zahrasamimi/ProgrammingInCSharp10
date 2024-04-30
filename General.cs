using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaseBackend.ProgrammingInCSharp10.Common
{
    public static class General
    {
        public static bool CheckMobileValidation(string mobileNumber)
        {
            const string pattern = @"^09[0|1|2|3][0-9]{8}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(mobileNumber);
        }

        public static bool CheckEmailValidation(string email)
        {
            return true;
        }

        public static bool CheckAddressValidation(string address)
        {
            return true;
        }

        public static bool CheckNationalCodeValidation(string nationalCode)
        {
            return true;
        }
    }
}
