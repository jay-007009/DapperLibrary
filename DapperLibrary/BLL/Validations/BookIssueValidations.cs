using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace DapperLibrary.BLL.Validations
{
    public class BookIssueValidations
    {
        public static bool IsvalidatebookIssue(BookIssue bookissuedetail)
        {
           
            Date joiningDateValidation = new Date();
          

          
            var IsdatejoiningValid = joiningDateValidation.IsDateIsValid(bookissuedetail.BookDateIssue);
          

            if (IsdatejoiningValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IsbookissueAdd(BookIssue bookissuedetails)
        {
            DapperLibrary.DAL.BookIssueOperation bookissuedetail = new DapperLibrary.DAL.BookIssueOperation();
            var bookissuedetailsvalidate = BookIssueValidations.IsvalidatebookIssue(bookissuedetails);
            if (bookissuedetailsvalidate ==true)
            {
                bookissuedetail.AddBookIssue(bookissuedetails);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "BookIssue Insert Successfully";
        }

        public static string Isupdatebookissue(int bookissueId, BookIssue bookissuedetails)
        {
            DapperLibrary.DAL.BookIssueOperation bookissuedetail = new DapperLibrary.DAL.BookIssueOperation();
            var bookissuedetailsvalidate = BookIssueValidations.IsvalidatebookIssue(bookissuedetails);
            if (bookissuedetailsvalidate== true)
            {
                bookissuedetail.UpdateBookIssueDetails(bookissueId, bookissuedetails);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "BookIssue Update Successfully";
        }
    }
}
