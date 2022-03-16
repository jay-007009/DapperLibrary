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
        public string AddSupplier(Suppliers supplier)
        {
            try
            {

                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    string sQuery = @"Insert into LMS_SUPPLIERSDETAILS(SUPPLIER_NAME,ADDRESS,CITY,PINCODE,CONTACT,EMAIL)values(@SupplierName,@address,@City,@Pincode,@Contact,@Email) SELECT @@IDENTITY ";
                    connection.Execute(sQuery, supplier); ;
                }
                foreach(var Bookdetails in supplier.bookdetaillist)
                {
                    string sQuery = @"Insert into LMS_BOOKDETAILS(BOOKTITLE,CATEGORY,AUTHOR,PUBLICATION,PUBLISH_DATE,BOOK_EDITION,PRICE,RANK_NUM,DATE_ARRIVAL, ) 
                                        values(@SupplierName,@address,@City,@Pincode,@Contact,@Email)";
                }
                return "Supplier insert Successfully";
            }
            catch (Exception e)
            {
                return e.Message;
            }

            //try
            //{
            //    using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
            //    {
            //        connectionData.connectionstring();
            //        connection.Open();
            //        connection.Execute("AddMembers", member, commandType: CommandType.StoredProcedure);
            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }

        public string DeleteSupplier(int supplierId)
        {
            throw new NotImplementedException();
        }

        public Suppliers GetSupplierById(int supplierId)
        {
            throw new NotImplementedException();
        }

        public string UpdateSupplierDetails(int supplierId, Suppliers suppliers)
        {
            throw new NotImplementedException();
        }
    }
}
