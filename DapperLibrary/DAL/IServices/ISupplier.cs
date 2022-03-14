using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL.IServices
{
   public interface ISupplier
    {
        public string AddSupplier(Suppliers supplier);
        public Suppliers GetSupplierById(int supplierId);
        public string UpdateSupplierDetails(int supplierId, Suppliers suppliers);
        public string DeleteSupplier(int supplierId);
    }
}
