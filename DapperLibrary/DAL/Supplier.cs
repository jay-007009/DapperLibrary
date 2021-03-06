using Dapper;
using DapperLibrary.ConnectionString;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.DAL
{
    public class Supplier : ISupplier
    {
        private readonly Connection connectionData = new Connection();
        public virtual string AddSupplier(Suppliers supplier)
        {
            try
            {



                var Sp = "AddSupplier";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             SupplierName = supplier.SupplierName,
                             SupplierAddress = supplier.SupplierAddress,
                             SupplierCity = supplier.SupplierCity,
                             SupplierPincode = supplier.SupplierPincode,
                             Suppliercontact = supplier.SupplierContact,
                             SupplierEmail = supplier.SupplierEmail

                         },
                        commandType: CommandType.StoredProcedure

                    );

                    return "Supplier Insert Successfully";
                }
             
           
            }
            catch (Exception e)
            {
                return e.Message;
            }

          
        }

        public virtual string DeleteSupplier(int supplierId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    

                    var parameter = new DynamicParameters();
                    parameter.Add("@SupplierId", supplierId);

                    connection.Open();
                    connection.Execute("Deletesupplier", parameter, commandType: CommandType.StoredProcedure);
                    connection.Close();

                }
                return "Members Deleted Successfully";

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
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                  
                    string readquery = "GetsupplierById";
                    connection.Open();
                    return connection.Query<Suppliers>(readquery, new { SupplierId = supplierId }, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                
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
                var Sp = "Updatesupplier";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    

                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             SupplierName = suppliers.SupplierName,
                             Address = suppliers.SupplierAddress,
                             city = suppliers.SupplierCity,
                             Pincode = suppliers.SupplierPincode,
                             contact = suppliers.SupplierContact,
                             Email = suppliers.SupplierEmail,
                           
                             SupplierId = supplierId
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();


                }

                return "Update SupplierDetails Successfully";



            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
