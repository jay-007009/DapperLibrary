using Dapper;
using DapperLibrary.BLL.Validations;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Validations;
namespace DapperLibrary.BLL
{
    public class MemberBAL : IMembersBAL
    {

        private readonly IMembers _members;
        public MemberBAL(IMembers members)
        {
            _members = members;
        }

        public virtual string ADDMembers(LibraryMembers member)
        {
            // DapperLibrary.DAL.Members members = new DapperLibrary.DAL.Members();

            try
            {
                return MemberValidations.IsmemberAdd(member);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public virtual string DeleteMember(int memberId)
        {

            try
            {

                return _members.DeleteMember(memberId);

            }
            catch (Exception)
            {
                return null;

            }


        }

        public virtual LibraryMembers GetMemberById(int memberId)
        {

            try
            {
                return _members.GetMemberById(memberId);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public virtual string UpdateMemberDetails(int memberId, LibraryMembers member)
        {


            try
            {

                return MemberValidations.Isupdatemember(memberId, member);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

    }

}




