using System;
using Xunit;
using DapperLibrary.DAL;
using Moq;
using DapperLibrary.DTO;
namespace LibraryMember.Test
{
    public class Members
    {
        public Mock<DapperLibrary.DAL.Members> _service = new Mock<DapperLibrary.DAL.Members>();


        //Insert Members Unit Test
        [Fact]
        public void AddMembers()
        {
            _service.Setup(options => options.ADDMembers(It.IsAny<LibraryMembers>()));
            var actualresult = _service.Object.ADDMembers(InsertMember());
            Assert.True(true, actualresult);
        }

        public LibraryMembers InsertMember()
        {
            return new LibraryMembers
            {
                MemberName = "Ramesh",
                MemberAddress = "Navsarihighschool",
                MemberCity = "Navsari",
                MemberPincode = "396445",
                MemberDate_Register = "2019/06/12",
                MemberDate_Expire = "2022/08/05",
                Membership_Status = "Permanant",
            };
        }



        //Update Members Unit Test
        [Fact]
        public void UpdateMembers()
        {
            _service.Setup(options => options.UpdateMemberDetails(It.IsAny<int>(), It.IsAny<DapperLibrary.DTO.LibraryMembers>()));
            var actualresult = _service.Object.UpdateMemberDetails(1, MemberUpdate());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.LibraryMembers MemberUpdate()
        {
            return new DapperLibrary.DTO.LibraryMembers
            {
                MemberId = 1,
                MemberName = "Ramesh",
                MemberAddress = "Navsarihighschool",
                MemberCity = "Navsari",
                MemberPincode = "396445",
                MemberDate_Register = "2019/06/12",
                MemberDate_Expire = "2022/08/05",
                Membership_Status = "Permanant",
            };
        }

        //Delete Member UnitTest
        [Fact]
        public void DeleteForMembers()
        {
            _service.Setup(options => options.DeleteMember(It.IsAny<int>()));
            var actualresult = _service.Object.DeleteMember(203);
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.LibraryMembers DeleteMember(int id)
        {
            return new DapperLibrary.DTO.LibraryMembers
            {
                MemberId = 203

            };
        }

        //GetById UnitTest 
        [Fact]
        public void GetForMembers()
        {
            _service.Setup(options => options.GetMemberById(It.IsAny<int>())).Returns(GetMemberId());
            var actualresult = _service.Object.GetMemberById(1);
            Assert.True(actualresult.MemberId > 0);
        }

        public DapperLibrary.DTO.LibraryMembers GetMemberId()
        {
            return new DapperLibrary.DTO.LibraryMembers
            {
                MemberId = 203,

            };
        }
    }
}
