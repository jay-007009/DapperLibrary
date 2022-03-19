using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DTO
{
    public class BookDetails
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "BookTitle is Required")]
       // [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "BookCategory is Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string BookCategory { get; set; }

        [Required(ErrorMessage = "BookAuthor is Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "BookPublication is Required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string BookPublication { get; set; }

        [Required(ErrorMessage = "BookPublish_Date is Required")]
        [RegularExpression("[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in format"))]
        public string BookPublish_Date { get; set; }

        [Required(ErrorMessage = "BookEdition is Required")]
        [RegularExpression("^[1-9][0-9]{0}$", ErrorMessage = ("Only 1 digits are allowed"))]
        public int BookEdition { get; set; }

        [Required(ErrorMessage = "BookPrice is Required")]
        [RegularExpression("^\\d{0,4}(\\.\\d{1,2})?$", ErrorMessage = ("BookPrice is Decimal "))]
        public string BookPrice { get; set; }

        [Required(ErrorMessage = "BookRankNumber is Required")]
        [RegularExpression("[A-Z0-9]{2}", ErrorMessage = ("BookRankNumber is in Format"))]
        public string BookRank_Number { get; set; }

        [Required(ErrorMessage = "BookDate Arrival is Required")]
        [RegularExpression("[0-9]{4}/[0-9]{2}/[0-9]{2}", ErrorMessage = ("date in yyyy/mm/dd"))]
        public string BookDate_Arrival { get; set; }

      
        public int SupplierId { get; set; }

     //  public List<Suppliers> suppliersList = new List<Suppliers>();

     //public BookDetails()
     //   {
     //       suppliersList = new List<Suppliers>();
     //   }


    }
}
