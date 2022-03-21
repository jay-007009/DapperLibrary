using Dapper;
using DapperLibrary.BLL.IServices;
using DapperLibrary.BLL.Validations;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.BLL
{
    public class SupplierBAL : ISupplierBAL
    {
        private readonly ISupplier _suppliers;
        public SupplierBAL(ISupplier suppliers)
        {
            _suppliers = suppliers;
        }
        public virtual string AddSupplier(Suppliers supplier)
        {
          

            try
            {
                return SupplierValidations.IssupplierAdd(supplier);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }






        }

        public virtual string DeleteSupplier(int supplierId)
        {
            try
            {

                return _suppliers.DeleteSupplier(supplierId);

            }
            catch (Exception)
            {
                return null;

            }
        }

        public virtual Suppliers GetSupplierById(int supplierId)
        {
            try
            {
                return _suppliers.GetSupplierById(supplierId);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public virtual string UpdateSupplierDetails(int supplierId, Suppliers suppliers)
        {
           

                try
                {

                    return SupplierValidations.Isupdatesupplier(supplierId, suppliers);

                }
                catch (Exception ex)
                {

                    return ex.Message;
                }

          
        }
    }
}
