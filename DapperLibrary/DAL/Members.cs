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
        public virtual   string ADDMembers(LibraryMembers member)
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

                var Sp = "AddMembers";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             MemberName = member.MemberName,
                             MemberAddress = member.MemberAddress,
                             MemberCity = member.MemberCity,
                             MemberPincode = member.MemberPincode,
                             Date_Register = member.MemberDate_Register,
                             Date_Expire = member.MemberDate_Expire,
                             Membership_Status = member.Membership_Status
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();
                }
                return "Member insert Successfully";
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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    //    string sQuery = @"Delete from LMS_MEMBERS where MEMBER_ID = @MemberId";
                    //    var parameter = new DynamicParameters();
                    //    parameter.Add("MemberId", memberId);
                    //    var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();

                    var parameter = new DynamicParameters();
                    parameter.Add("@MemberId", memberId);

                    connection.Open();
                    connection.Execute("DeleteMembers", parameter, commandType: CommandType.StoredProcedure);
                    connection.Close();

                }
                return "Members Deleted Successfully";

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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    ////string sQuery = @"Select MEMBER_ID, MEMBER_NAME,ADDRESS,CITY,PINCODE,DATE_REGISTER,DATE_EXPIRE,MEMBERSHIP_STATUS from LMS_MEMBERS where MEMBER_ID = @MemberId";
                    //DynamicParameters parameter = new DynamicParameters();
                    ////parameter.Add("MemberId", memberId);
                    ////var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();
                    ////return members;


                    //connection.Open();
                    //IList<LibraryMembers> memberList = SqlMapper.Query<LibraryMembers>(
                    //                  connection, "GetMembers").ToList();
                    //parameter.Add("@MemberId", memberId);
                    //connection.Close();
                    //return memberList.ToList();

                    string readquery = "GetMembers";
                    connection.Open();
                    return connection.Query<LibraryMembers>(readquery, new { MemberId = memberId }, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
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
                var Sp = "UpdateMembers";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    //string sQuery = @"Update LMS_MEMBERS set MEMBERNAME=@MemberName,ADDRESS=@Address,CITY=@city,PINCODE=@Pincode,DATE_REGISTER=@DateRegister,DATE_EXPIRE=@DateExpire,MEMBERSHIP_STATUS=@Membershipstatus"+
                    //                 "where MEMBERID = @MemberId";

                    //var parameter = new DynamicParameters();
                    //parameter.Add("MemberId", memberId);
                    //parameter.Add("MemberName", member.MemberName);
                    //parameter.Add("Address", member.MemberAddress);
                    //parameter.Add("city", member.MemberCity);
                    //parameter.Add("Pincode", member.MemberPincode);
                    //parameter.Add("DateRegister", member.MemberDate_Register);
                    //parameter.Add("DateExpire", member.MemberDate_Expire);
                    //parameter.Add("Membershipstatus", member.Membership_Status);

                    //var members = connection.Query<LibraryMembers>(sQuery, parameter).FirstOrDefault();

                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             MemberName = member.MemberName,
                             Address = member.MemberAddress,
                             city = member.MemberCity,
                             Pincode = member.MemberPincode,
                             DateRegister = member.MemberDate_Register,
                             DateExpire = member.MemberDate_Expire,
                             Membershipstatus = member.Membership_Status,
                             MemberId=memberId
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();


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

