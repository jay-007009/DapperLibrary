using System;
using System.Text.RegularExpressions;

namespace Validations
{
    public class Name
    {
        public bool IsNameIsValid(string name)
        {

            Regex regex = new Regex(@"^[a-zA-Z]+$");
            Match match = regex.Match(name);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
