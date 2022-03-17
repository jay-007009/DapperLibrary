using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DTO
{
    public class LibraryFineDetails
    {
      //  [Key]
        public string FineRange { get; set; } //Primary Key

        

      [Required(ErrorMessage = "FineAmount is Required")]
//[RegularExpression("^\\d{0,4}(\\.\\d{1,2})?$", ErrorMessage = ("FineAmount "))]
public string FineAmount { get; set; }
    }
}
