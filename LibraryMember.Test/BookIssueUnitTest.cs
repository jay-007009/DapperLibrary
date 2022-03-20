using DapperLibrary.DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryMember.Test
{
    public class BookIssueUnitTest
    {
        public Mock<DapperLibrary.DAL.BookIssueOperation> _service = new Mock<DapperLibrary.DAL.BookIssueOperation>();


        //Insert BookIssueDetails Unit Test
        [Fact]
        public void AddBookDetails()
        {
            _service.Setup(options => options.AddBookIssue(It.IsAny<BookIssue>()));
            var actualresult = _service.Object.AddBookIssue(InsertBookIssueDetails());
            Assert.True(true, actualresult);
        }

        public BookIssue InsertBookIssueDetails()
        {
            return new BookIssue
            {
                MemberId = 1,
                BookCodeId = 3,
                BookDateIssue = "2020/12/10",
                BookDateReturn = "2024/10/10",
                FineRange = "A2"
            };
        }



        //Update BookIssueDetails Unit Test
        [Fact]
        public void UpdateBookIssueDetails()
        {
            _service.Setup(options => options.UpdateBookIssueDetails(It.IsAny<int>(), It.IsAny<DapperLibrary.DTO.BookIssue>()));
            var actualresult = _service.Object.UpdateBookIssueDetails(1, BookIssueDetailUpdate());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.BookIssue BookIssueDetailUpdate()
        {
            return new DapperLibrary.DTO.BookIssue
            {
                BookIssueId = 1,
                MemberId = 1,
                BookCodeId = 3,
                BookDateIssue = "2019/12/10",
                BookDateReturn = "2024/10/10",
                FineRange = "B2"
            };
        }

        //Delete BookIssueDetails UnitTest
        [Fact]
        public void DeleteForBookIssueDetails()
        {
            _service.Setup(options => options.DeleteBookIssue(It.IsAny<int>()));
            var actualresult = _service.Object.DeleteBookIssue(203);
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.BookIssue DeleteBookIssueDetails(int id)
        {
            return new DapperLibrary.DTO.BookIssue
            {
                BookIssueId = 203

            };
        }

        //GetBookIssueDetail By Id UnitTest 
        [Fact]
        public void GetForBookIssueDetails()
        {
            _service.Setup(options => options.GetBookIssueById(It.IsAny<int>())).Returns(GetBookIssueDetailById());
            var actualresult = _service.Object.GetBookIssueById(1);
            Assert.True(actualresult.BookIssueId > 0);
        }

        public DapperLibrary.DTO.BookIssue GetBookIssueDetailById()
        {
            return new DapperLibrary.DTO.BookIssue
            {
                BookIssueId = 203,

            };
        }
    }
}
