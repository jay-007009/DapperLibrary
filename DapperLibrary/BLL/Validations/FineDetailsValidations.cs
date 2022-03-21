using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace DapperLibrary.BLL.Validations
{
    public class FineDetailsValidations
    {
        public static bool Isvalidatefinedetails(LibraryFineDetails finedetails)
        {
            Amount amount_Validation = new Amount();
         

            var amountisvalid = amount_Validation.IsAmountIsValid(finedetails.FineAmount);
          

            if (amountisvalid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IsfinedetailsAdd(LibraryFineDetails finedetail)
        {
            DapperLibrary.DAL.FineDetails finedetails = new DapperLibrary.DAL.FineDetails();
            var finedetailsvalidate = FineDetailsValidations.Isvalidatefinedetails(finedetail);
            if (finedetailsvalidate)
            {
                finedetails.AddFineDetails(finedetail);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Fine Details Insert Successfully";
        }

        public static string Isupdatefinedetails(string finedetailId, LibraryFineDetails finedetail)
        {
            DapperLibrary.DAL.FineDetails finedetails = new DapperLibrary.DAL.FineDetails();
            var finedetailsvalidate = FineDetailsValidations.Isvalidatefinedetails(finedetail);
            if (finedetailsvalidate)
            {
                finedetails.UpdateFineDetails(finedetailId, finedetail);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Fine Details Update Successfully";
        }
    }
}
