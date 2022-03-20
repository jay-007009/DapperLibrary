using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
   public class Pincode
    {

        public bool PincodeIsValid(string pincode)
        {

            Regex regex = new Regex(@"^[1-9][0-9]{5}$");
            Match match = regex.Match(pincode);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
