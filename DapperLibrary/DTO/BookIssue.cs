using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DTO
{
    public class BookIssue
    {
        [Key]
        public int BookIssueId { get; set; }

        public int MemberId { get; set; }
        public int BookCodeId { get; set; }

        [Required(ErrorMessage = "BookDateIssue is Required")]
        [RegularExpression("[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in format"))]
        public string BookDateIssue { get; set; }

        [Required(ErrorMessage = "BookDateReturn is Required")]
        [RegularExpression("[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in format"))]
        public string BookDateReturn { get; set; }


        public string FineRange { get; set; } //Reference
       
     

    

    }
}
