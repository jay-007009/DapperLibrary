using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DTO
{
    public class BookIssue
    {
        public int BookIssueId { get; set; }
        public string BookTitle { get; set; }
        public string BookDateIssue { get; set; }
        public string BookDateReturn { get; set; }
        public string FineRange { get; set; } //Reference
       
        public int MemberId { get; set; }
        public int BookId { get; set; }

        public List<LibraryFineDetails> FineList { get; set; }
        public List<LibraryMembers> MembersList { get; set; }
        public List<BookDetails> BookDetailsList { get; set; }

        public BookIssue()
        {
            MembersList = new List<LibraryMembers>();
            BookDetailsList = new List<BookDetails>();
            FineList = new List<LibraryFineDetails>();
        }

    }
}
