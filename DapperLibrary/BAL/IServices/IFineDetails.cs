using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.BAL.IServices
{
   public interface IFineDetails
    {
        public string AddFineDetails(LibraryFineDetails finedetails);
        public LibraryFineDetails GetFineDetailsById(string finedetailId);
        public string UpdateFineDetails(string finedetailId, LibraryFineDetails fineDetails);
        public string DeleteFineDetails(string finedetailId);
    }
}
