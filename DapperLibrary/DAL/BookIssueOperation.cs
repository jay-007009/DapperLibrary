using Dapper;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL
{
    public class BookIssueOperation : IBookIssue
    {
        private readonly Connection connectionData = new Connection();
        public virtual string AddBookIssue(BookIssue bookissue)
        {
          
            try
            {

                var Sp = "AddBookIssue";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             MemberId = bookissue.MemberId,
                             Bookcode = bookissue.BookCodeId,
                             DateIssue = bookissue.BookDateIssue,
                             DateReturn = bookissue.BookDateReturn,
                             FineRange = bookissue.FineRange
                            
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();
                }
                return "Book Issue Insert Successfully";
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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {


                    var parameter = new DynamicParameters();
                    parameter.Add("@BookIssueId", bookissueId);

                    connection.Open();
                    connection.Execute("DeleteBookIssue", parameter, commandType: CommandType.StoredProcedure);
                    connection.Close();

                }
                return "BookIssue Details Deleted Successfully";

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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {


                    string readquery = "GetBookIssue";
                    connection.Open();
                    return connection.Query<BookIssue>(readquery, new { BookIssueId = bookissueId }, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
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
                var Sp = "UpdateBookIssue";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {


                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             MemberId = bookissue.MemberId,
                             BookCode = bookissue.BookCodeId,
                             DateIssue = bookissue.BookDateIssue,
                             DateReturn = bookissue.BookDateReturn,
                             FineRange = bookissue.FineRange,
                             BookIssueNo = bookissueId
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();


                }

                return "Update BookIssueDetails Successfully";



            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
