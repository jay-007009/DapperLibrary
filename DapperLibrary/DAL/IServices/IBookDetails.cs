using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL.IServices
{
    public interface IBookDetails
    {
        public string AddBookDetails(BookDetails bookdetail);
        public DapperLibrary.DTO.BookDetails GetBookById(int bookId);
        public string UpdateBookDetails(int bookId, DapperLibrary.DTO.BookDetails bookdetail);
        public string DeleteBook(int bookId);
    }
}
