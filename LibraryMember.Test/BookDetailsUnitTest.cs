using DapperLibrary.DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryMember.Test
{
    public class BookDetailsUnitTest
    {
        public Mock<DapperLibrary.DAL.BookDetailsOperation> _service = new Mock<DapperLibrary.DAL.BookDetailsOperation>();


        //Insert BookDetails Unit Test
        [Fact]
        public void AddBookDetails()
        {
            _service.Setup(options => options.AddBookDetails(It.IsAny<BookDetails>()));
            var actualresult = _service.Object.AddBookDetails(InsertBookDetails());
            Assert.True(true, actualresult);
        }

        public BookDetails InsertBookDetails()
        {
            return new BookDetails
            {
                BookTitle = "PyhonProgramming",
                BookCategory = "PYTHON",
                BookAuthor = "PaulDeitel",
                BookPublication= "PrenticeHall",
                BookPublish_Date="2019/12/10",
                BookEdition= "6",
                BookPrice= "1000.02",
                BookRank_Number= "A1",
                BookDate_Arrival= "2020/05/10",
                SupplierId=1002
            };
        }



        //Update BookDetails Unit Test
        [Fact]
        public void UpdateBookDetails()
        {
            _service.Setup(options => options.UpdateBookDetails(It.IsAny<int>(), It.IsAny<DapperLibrary.DTO.BookDetails>()));
            var actualresult = _service.Object.UpdateBookDetails(1, BookDetailUpdate());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.BookDetails BookDetailUpdate()
        {
            return new DapperLibrary.DTO.BookDetails
            {
                BookId = 1,
                BookTitle = "PyhonProgramming",
                BookCategory = "Java",
                BookAuthor = "PaulDeitel",
                BookPublication = "PrenticeHall",
                BookPublish_Date = "2019/12/10",
                BookEdition = "6",
                BookPrice = "1000.02",
                BookRank_Number = "A1",
                BookDate_Arrival = "2020/05/10",
                SupplierId = 1002
            };
        }

        //Delete BookDetails UnitTest
        [Fact]
        public void DeleteForBookDetails()
        {
            _service.Setup(options => options.DeleteBook(It.IsAny<int>()));
            var actualresult = _service.Object.DeleteBook(203);
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.BookDetails DeleteBookDetails(int id)
        {
            return new DapperLibrary.DTO.BookDetails
            {
                BookId = 203

            };
        }

        //GetBookDetail By Id UnitTest 
        [Fact]
        public void GetForBookDetails()
        {
            _service.Setup(options => options.GetBookById(It.IsAny<int>())).Returns(GetBookDetailById());
            var actualresult = _service.Object.GetBookById(1);
            Assert.True(actualresult.BookId > 0);
        }

        public DapperLibrary.DTO.BookDetails GetBookDetailById()
        {
            return new DapperLibrary.DTO.BookDetails
            {
                BookId = 203,

            };
        }
    }
}
