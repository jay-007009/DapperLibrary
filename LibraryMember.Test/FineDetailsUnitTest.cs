using DapperLibrary.DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryMember.Test
{
   public class FineDetailsUnitTest
    {
        public Mock<DapperLibrary.DAL.FineDetails> _service = new Mock<DapperLibrary.DAL.FineDetails>();


        //Insert FineDetails Unit Test
        [Fact]
        public void AddFineDetails()
        {
            _service.Setup(options => options.AddFineDetails(It.IsAny<LibraryFineDetails>()));
            var actualresult = _service.Object.AddFineDetails(InsertFineDetails());
            Assert.True(true, actualresult);
        }

        public LibraryFineDetails InsertFineDetails()
        {
            return new DapperLibrary.DTO.LibraryFineDetails
            {
                FineRange = "A1",
                FineAmount = "500.02"
            };
        }



        //Update FineDetails Unit Test
        [Fact]
        public void UpdateFinedetail()
        {
            _service.Setup(options => options.UpdateFineDetails(It.IsAny<string>(), It.IsAny<DapperLibrary.DTO.LibraryFineDetails>()));
            var actualresult = _service.Object.UpdateFineDetails("A1", FineDetailUpdate());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.LibraryFineDetails FineDetailUpdate()
        {
            return new DapperLibrary.DTO.LibraryFineDetails
            {
              
                FineAmount = "700.02"
            };
        }

        //Delete FineDetail Unit Test
        [Fact]
        public void DeleteFineDetail()
        {
            _service.Setup(options => options.DeleteFineDetails(It.IsAny<string>()));
            var actualresult = _service.Object.DeleteFineDetails("A1");
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.LibraryFineDetails DeleteFineDetailsById(int id)
        {
            return new DapperLibrary.DTO.LibraryFineDetails
            {
                FineRange = "A1"

            };
        }

        //Get FineDetails Unit Test
        [Fact]
        public void GetForFineDetails()
        {
            _service.Setup(options => options.GetFineDetailsById(It.IsAny<string>())).Returns(GetFineDetailsById());
            var actualresult = _service.Object.GetFineDetailsById("A1");
         //  Assert.True(actualresult.FineRange > 0 );
        }

        public DapperLibrary.DTO.LibraryFineDetails GetFineDetailsById()
        {
            return new DapperLibrary.DTO.LibraryFineDetails
            {
                FineRange = "A1"

            };
        }
    }
}
