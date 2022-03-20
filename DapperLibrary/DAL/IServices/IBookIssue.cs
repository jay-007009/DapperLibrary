using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL.IServices
{
   public interface IBookIssue
    {
        public string AddBookIssue(BookIssue bookissue);
        public BookIssue GetBookIssueById(int bookissueId);
        public string UpdateBookIssueDetails(int bookissueId, BookIssue bookissue);
        public string DeleteBookIssue(int bookissueId);
    }
}
