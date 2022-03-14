using Dapper;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL
{
    public class Members : IMembers
    {
        private readonly Connection connectionData = new Connection();
        public string ADDMembers(LibraryMembers member)
        {
            //try
            //{

            //    using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
            //    {
            //        string sQuery = @"Insert into LMS_MEMBERS(MEMBER_NAME,ADDRESS,CITY,PINCODE,DATE_REGISTER,DATE_EXPIRE,MEMBERSHIP_STATUS)  values(@MemberName,@address,@City,@Pincode,@DateRegister,@DateExpire,@MembershipStatus) select Scope_Identity";
            //        connection.Execute(sQuery, member);
            //    }

            //    return "Member insert Successfully";
            //}
            //catch (Exception e)
            //{
            //    return e.Message;
            //}

            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    connectionData.connectionstring();
                    connection.Open();
                    connection.Execute("AddMembers", member, commandType: CommandType.StoredProcedure);
                    connection.Close();
                }
                return "Member insert Successfully";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string DeleteMember(int memberId)
        {

            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    string sQuery = @"Delete from LMS_MEMBERS where MemberId = @MemberId";
                    var parameter = new DynamicParameters();
                    parameter.Add("MemberId", memberId);
                    var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();
                    
                }
                return "Members Deleted Successfully";

            }
            catch (Exception)
            {
                return null;

            }

          //  return "data deleted successfully";
        }

        public LibraryMembers GetMemberById(int memberId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    string sQuery = @"Select MemberId, MemberName,Address,City,Pincode,Date_Register,DateExpire,MembershipStatus from LMS_MEMBERS where MemberId = @MemberId";
                    var parameter = new DynamicParameters();
                    parameter.Add("MemberId", memberId);
                    var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();
                    return members;
                }


            }
            catch (Exception)
            {
                return null;

            }
        }

        public string UpdateMemberDetails(int memberId, LibraryMembers member)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    string sQuery = @"Update LMS_MEMBERS set MemberName=@MemberName,Address=@Address,City=@city,Pincode= @Pincode,DateRegister= @DateRegister,
                                   DateExpire= @DateExpire,MembershipStatus=@Membershipstatus " +
                                     "where MemberId = @MemberId";

                    var parameter = new DynamicParameters();
                    parameter.Add("MemberId", memberId);
                    parameter.Add("MemberName", member.MemberName);
                    parameter.Add("Address", member.MemberAddress);
                    parameter.Add("City", member.MemberCity);
                    parameter.Add("Pincode", member.MemberPincode);
                    parameter.Add("DateRegister", member.MemberDate_Register);
                    parameter.Add("DateExpire", member.MemberDate_Expire);
                    parameter.Add("MemberShipStatus", member.Membership_Status);

                    var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();
                   
                }

                return "Update Member Successful";



            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }

    
}

