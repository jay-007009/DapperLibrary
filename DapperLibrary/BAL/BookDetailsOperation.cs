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

namespace DapperLibrary.BAL
{
    public class BookDetailsOperation : IBookDetails
    {
        private readonly Connection connectionData = new Connection();
        public virtual string AddBookDetails(BookDetails bookdetail)
        {

            try
            {
                
                    var Sp = "AddBookDetails";
                    using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                    {
                        connection.Open();
                        connection.Execute
                        (
                            Sp,
                             new
                             {
                                 BookTitle = bookdetail.BookTitle,
                                 Category = bookdetail.BookCategory,
                                 Author = bookdetail.BookAuthor,
                                 Publication = bookdetail.BookPublication,
                                 Publishdate = bookdetail.BookPublish_Date,
                                 BookEdition = bookdetail.BookEdition,
                                 Price = bookdetail.BookPrice,
                                 RankNumber = bookdetail.BookRank_Number,
                                 DateArrival = bookdetail.BookDate_Arrival,
                                 SupplierId = bookdetail.SupplierId
                             },
                            commandType: CommandType.StoredProcedure
                        );
                        connection.Close();
                    }
               
                    return "BookDetails insert Successfully";
                

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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                  

                    var parameter = new DynamicParameters();
                    parameter.Add("@BookId", bookId);

                    connection.Open();
                    connection.Execute("DeleteBookdetails", parameter, commandType: CommandType.StoredProcedure);
                    connection.Close();

                }
                return "BookDetails Deleted Successfully";

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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                  

                    string readquery = "GetBookDetails";
                    connection.Open();
                    return connection.Query<BookDetails>(readquery, new { BookCode = bookId }, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
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
                var Sp = "UpdateBookDetails";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                  
                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             BookTitle = bookdetail.BookTitle,
                             Category = bookdetail.BookCategory,
                             Author = bookdetail.BookAuthor,
                             Publication = bookdetail.BookPublication,
                             Publishdate = bookdetail.BookPublish_Date,
                             BookEdition = bookdetail.BookEdition,
                             Price = bookdetail.BookPrice,
                             RankNumber = bookdetail.BookRank_Number,
                             DateArrival = bookdetail.BookDate_Arrival,
                             SupplierId=bookdetail.SupplierId,
                             Bookcode = bookId
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();


                }

                return "Update BookDetails Successfully";



            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
