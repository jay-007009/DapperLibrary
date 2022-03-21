using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validations
{
   public class BookRankNum
    {
        public bool IsBookRankNumIsValid(string bookranknum)
        {

            Regex regex = new Regex(@"[A-Z0-9]{2}");
            Match match = regex.Match(bookranknum);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
