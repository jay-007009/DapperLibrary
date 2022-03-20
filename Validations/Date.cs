using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
   public class Date
    {
        public bool IsDateIsValid(string date)
        {

            Regex regex = new Regex(@"[0-9]{4}/[0-9]{2}/[0-9]{2}");
            Match match = regex.Match(date);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
