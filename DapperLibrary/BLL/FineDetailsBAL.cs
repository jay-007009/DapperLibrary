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

namespace DapperLibrary.BAL
{
    public class FineDetailsBAL : IFineDetailsBAL
    {
        private readonly IFineDetails _finedetails;
        public FineDetailsBAL(IFineDetails finedetails)
        {
            _finedetails = finedetails;
        }
        public virtual string AddFineDetails(LibraryFineDetails finedetails)
        {
            try
            {
                return FineDetailsValidations.IsfinedetailsAdd(finedetails);

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

                return _finedetails.DeleteFineDetails(finedetailId);

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
                return _finedetails.GetFineDetailsById(finedetailId);
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

                return FineDetailsValidations.Isupdatefinedetails(finedetailId, fineDetails);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
