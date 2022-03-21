using Dapper;
using DapperLibrary.BLL.IServices;
using DapperLibrary.BLL.Validations;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.BLL
{
    public class BookDetailsOperationBAL : IBookDetailsBAL
    {
        private readonly IBookDetails _bookdetails;
        public BookDetailsOperationBAL(IBookDetails bookdetails)
        {
            _bookdetails = bookdetails;
        }
        public virtual string AddBookDetails(BookDetails bookdetail)
        {

            try
            {
                return BookDetailsValidations.IsbookdetailAdd(bookdetail);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

       

        public virtual string DeleteBook(int bookId)
        {
            try
            {

                return _bookdetails.DeleteBook(bookId);

            }
            catch (Exception)
            {
                return null;

            }
        }

        public virtual BookDetails GetBookById(int bookId)
        {
            try
            {
                return _bookdetails.GetBookById(bookId);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public virtual string UpdateBookDetails(int bookId, DapperLibrary.DTO.BookDetails bookdetail)
        {
            try
            {

                return BookDetailsValidations.Isupdatebookdetail(bookId, bookdetail);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
