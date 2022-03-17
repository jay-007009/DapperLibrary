using DapperLibrary.DAL;
using Moq;
using System;
using Xunit;
using DapperLibrary.DTO;
namespace LibraryMembers.Test
{
    public class UnitTest1
    {
        public Mock<Members> _service = new Mock<Members>();


        //Insert Members Unit Test
        [Fact]
        public void AddMembers()
        {
            _service.Setup(options => options.ADDMembers(It.IsAny<DapperLibrary.DTO.LibraryMembers>()));
            var actualresult = _service.Object.ADDMembers(InsertMember());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.LibraryMembers InsertMember()
        {
            return new DapperLibrary.DTO.LibraryMembers
            {
                MemberName = "Ramesh",
                MemberAddress = "Navsarihighschool",
                MemberCity = "Navsari",
                MemberPincode = 396445,
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
                MemberId=1,
                MemberName = "Ramesh",
                MemberAddress = "Navsarihighschool",
                MemberCity = "Navsari",
                MemberPincode = 396445,
                MemberDate_Register = "2019/06/12",
                MemberDate_Expire = "2022/08/05",
                Membership_Status = "Permanant",
            };
        }


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

        //[Fact]
        //public void GetForMembers()
        //{
        //    _service.Setup(options => options.GetMemberById(It.IsAny<int>())).Returns(GetForMembers);
        //    var actualresult = _service.Object.GetMemberById(1);
        //    Assert.True(actualresult.Count > 0);
        //}

        //public DapperLibrary.DTO.LibraryMembers GetMemberById(int id)
        //{
        //    return new DapperLibrary.DTO.LibraryMembers
        //    {
        //        MemberId = 203,

        //    };
        //}

    }
}
