using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
    public class Amount
    {
        public bool IsAmountIsValid(string amount)
        {

            Regex regex = new Regex(@"^\\d{0,4}(\\.\\d{1,2})?$");
            Match match = regex.Match(amount);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
