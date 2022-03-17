using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL.IServices
{
   public interface IFineDetails
    {
        public string AddFineDetails(LibraryFineDetails finedetails);
        public LibraryFineDetails GetFineDetailsById(int finedetailId);
        public string UpdateFineDetails(int finedetailId, LibraryFineDetails fineDetails);
        public string DeleteFineDetails(int finedetailId);
    }
}
