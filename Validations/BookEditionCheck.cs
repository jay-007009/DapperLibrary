using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
     public class BookEditionCheck
    {
        public bool IsBookCheckIsValid(string BookCheck)
        {

            Regex regex = new Regex(@"^[1-9][0-9]{0}$");
            Match match = regex.Match(BookCheck);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
