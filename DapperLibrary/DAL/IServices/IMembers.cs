using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL.IServices
{
    public interface IMembers
    {
        public string ADDMembers(LibraryMembers member);
        public LibraryMembers GetMemberById(int memberId);
        public string UpdateMemberDetails(int memberId, LibraryMembers member);
        public string DeleteMember(int memberId);

    }
}
