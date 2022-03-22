using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace DapperLibrary.BLL.Validations
{
    public class BookDetailsValidations
    {
        public static bool Isvalidatebookdetails(BookDetails bookdetail)
        {
            Name name_Validation = new Name();
            Date joiningDateValidation = new Date();
            BookEditionCheck bookEditionCheckvalidation = new BookEditionCheck();
            Amount amountvalidation = new Amount();
            BookRankNum bookRankNumvalidation = new BookRankNum();

            var nameisvalid = name_Validation.IsNameIsValid(bookdetail.BookAuthor);
            var IsdatejoiningValid = joiningDateValidation.IsDateIsValid(bookdetail.BookPublish_Date);
            var Isbookeditioncheck = bookEditionCheckvalidation.IsBookCheckIsValid(bookdetail.BookEdition);
            var amountvalidationcheck = amountvalidation.IsAmountIsValid(bookdetail.BookPrice);
            var bookRankNumvalidationcheck  = bookRankNumvalidation.IsBookRankNumIsValid(bookdetail.BookRank_Number);

            if (nameisvalid && IsdatejoiningValid && Isbookeditioncheck && amountvalidationcheck && bookRankNumvalidationcheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IsbookdetailAdd(BookDetails bookdetails)
        {
            DapperLibrary.DAL.BookDetailsOperation bookdetail = new DapperLibrary.DAL.BookDetailsOperation();
            var bookdetailsvalidate = BookDetailsValidations.Isvalidatebookdetails(bookdetails);
            if (bookdetailsvalidate==false)
            {
                bookdetail.AddBookDetails(bookdetails);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "BookDetails Insert Successfully";
        }

        public static string Isupdatebookdetail(int bookdetailId, BookDetails bookdetails)
        {
            DapperLibrary.DAL.BookDetailsOperation bookdetail = new DapperLibrary.DAL.BookDetailsOperation();
            var bookdetailsvalidate = BookDetailsValidations.Isvalidatebookdetails(bookdetails);
            if (bookdetailsvalidate==false)
            {
                bookdetail.UpdateBookDetails(bookdetailId, bookdetails);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "BookDetails Update Successfully";
        }
    }
}
