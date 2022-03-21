using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
    public class Email
    {
        
            public bool IsEmailIsValid(string email)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
