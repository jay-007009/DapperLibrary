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

namespace DapperLibrary.BAL
{
    public class FineDetails : IFineDetails
    {
        private readonly Connection connectionData = new Connection();
        public virtual string AddFineDetails(LibraryFineDetails finedetails)
        {
            try
            {

                var Sp = "AddFineRange";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             FineRange = finedetails.FineRange,
                             FineAmount = finedetails.FineAmount
                            
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();
                }
                return "FineDetails insert Successfully";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public virtual string DeleteFineDetails(string finedetailId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                   

                    var parameter = new DynamicParameters();
                    parameter.Add("@FineRange", finedetailId);

                    connection.Open();
                    connection.Execute("DeleteFineDetails", parameter, commandType: CommandType.StoredProcedure);
                    connection.Close();

                }
                return "Fine Deleted Successfully";

            }
            catch (Exception)
            {
                return null;

            }
        }

      

        public virtual LibraryFineDetails GetFineDetailsById(string finedetailId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {
                    
                    string readquery = "GetFineDetails";
                    connection.Open();
                    return connection.Query<LibraryFineDetails>(readquery, new { FineRange = finedetailId }, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
               
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public virtual string UpdateFineDetails(string finedetailId, LibraryFineDetails fineDetails)
        {
            try
            {
                var Sp = "UpdateFineDetails";
                using (IDbConnection connection = new SqlConnection(connectionData.connectionstring()))
                {


                    connection.Open();
                    connection.Execute
                    (
                        Sp,
                         new
                         {
                             FineAmount = fineDetails.FineAmount,
                             FineRange = finedetailId,
                      
                           
                         },
                        commandType: CommandType.StoredProcedure
                    );
                    connection.Close();


                }

                return "Update FineDetails Successfully";



            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
