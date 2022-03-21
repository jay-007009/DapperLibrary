using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
    public class Contact
    {
        public bool IsContactIsValid(string contact)
        {

            Regex regex = new Regex(@"^[1-9][0-9]{9}$");
            Match match = regex.Match(contact);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
