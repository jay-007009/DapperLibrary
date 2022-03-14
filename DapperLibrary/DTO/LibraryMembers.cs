using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using Validations;

namespace DapperLibrary.DTO
{
    public class LibraryMembers
    {
        [Key]
        public int MemberId { get; set; }

       // [Required(ErrorMessage = "MemberName is Required")]
       // [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string MemberName { get; set; }

       // [Required(ErrorMessage = "MemberAddress is Required")]
      //  [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string MemberAddress { get; set; }

       // [Required(ErrorMessage = "MemberCity is Required")]
       // [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string MemberCity { get; set; }

       // [Required(ErrorMessage = "Pincode is Required")]
       // [RegularExpression("^[0-9]{6}+$", ErrorMessage = ("Only 6 digits are allowed"))]
       // [Range(1, 6)]
        public int MemberPincode { get; set; }


        //[DateValidate]
       // [Required(ErrorMessage = "MemberDate_Register is Required")]
      //  [RegularExpression(  @"[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in format"))]
        public string MemberDate_Register { get; set; }
        // [DateValidate]

      //  [Required(ErrorMessage = "MemberDate_Expire is Required")]
      //  [RegularExpression(@"[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in format"))]
        public string MemberDate_Expire { get; set; }


       // [Required(ErrorMessage = "MemberShip_Status is Required")]
      //  [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string Membership_Status { get; set; }

       // List<BookIssue> bookIssueslist = new List<BookIssue>();


       
    }
}
