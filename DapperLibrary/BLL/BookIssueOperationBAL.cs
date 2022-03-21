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
    public class BookIssueOperationBAL : IBookIssueBAL
    {
        private readonly IBookIssue _bookissue;
        public BookIssueOperationBAL(IBookIssue bookissue)
        {
            _bookissue = bookissue;
        }
        public virtual string AddBookIssue(BookIssue bookissue)
        {

            try
            {
                return BookIssueValidations.IsbookissueAdd(bookissue);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public virtual string DeleteBookIssue(int bookissueId)
        {
            try
            {

                return _bookissue.DeleteBookIssue(bookissueId);

            }
            catch (Exception)
            {
                return null;

            }
        }

        public virtual BookIssue GetBookIssueById(int bookissueId)
        {
            try
            {
                return _bookissue.GetBookIssueById(bookissueId);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public virtual string UpdateBookIssueDetails(int bookissueId, BookIssue bookissue)
        {
            try
            {

                return BookIssueValidations.Isupdatebookissue(bookissueId, bookissue);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
