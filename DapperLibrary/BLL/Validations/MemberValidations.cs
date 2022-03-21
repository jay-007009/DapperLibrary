using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace DapperLibrary.BLL.Validations
{
    public static class MemberValidations
    {
        public static bool Isvalidatemember(LibraryMembers member)
        {
            Name name_Validation = new Name();
            Pincode pincodeValidation = new Pincode();
            Date joiningDateValidation = new Date();

            var nameisvalid = name_Validation.IsNameIsValid(member.MemberName);
            var IspincodeValid = pincodeValidation.PincodeIsValid(member.MemberPincode);
            var IsdatejoiningValid = joiningDateValidation.IsDateIsValid(member.MemberDate_Register);

            if (nameisvalid && IsdatejoiningValid && IspincodeValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IsmemberAdd(LibraryMembers member)
        {
            DapperLibrary.DAL.Members members = new DapperLibrary.DAL.Members();
            var membervalidate = MemberValidations.Isvalidatemember(member);
            if (membervalidate)
            {
                members.ADDMembers(member);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Member Insert Successfully";
        }

        public static string Isupdatemember(int memberId, LibraryMembers member)
        {
            DapperLibrary.DAL.Members members = new DapperLibrary.DAL.Members();
            var membervalidate = MemberValidations.Isvalidatemember(member);
            if (membervalidate)
            {
                members.UpdateMemberDetails(memberId, member);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Member Update Successfully";
        }

    }
}
