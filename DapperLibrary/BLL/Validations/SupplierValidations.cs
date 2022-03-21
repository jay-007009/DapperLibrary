using DapperLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace DapperLibrary.BLL.Validations
{
    public static class SupplierValidations
    {
        public static bool Isvalidatesupplier(Suppliers supplier)
        {
            Name name_Validation = new Name();
            Pincode pincodeValidation = new Pincode();
            Contact contactvalidation = new Contact();
            Email emailvalidation = new Email();
            var nameisvalid = name_Validation.IsNameIsValid(supplier.SupplierName);
            var IspincodeValid = pincodeValidation.PincodeIsValid(supplier.SupplierPincode);
            var Iscontactvalid = contactvalidation.IsContactIsValid(supplier.SupplierContact);
            var Isemailvalid = emailvalidation.IsEmailIsValid(supplier.SupplierEmail);
            if (nameisvalid &&  IspincodeValid && Iscontactvalid && Isemailvalid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string IssupplierAdd(Suppliers supplier)
        {
            DapperLibrary.DAL.Supplier suppliers = new DapperLibrary.DAL.Supplier();
            var suppliervalidate = SupplierValidations.Isvalidatesupplier(supplier);
            if (suppliervalidate)
            {
                suppliers.AddSupplier(supplier);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Supplier Insert Successfully";
        }

        public static string Isupdatesupplier(int supplierId, Suppliers supplier)
        {
            DapperLibrary.DAL.Supplier suppliers = new DapperLibrary.DAL.Supplier();
            var suppliervalidate = SupplierValidations.Isvalidatesupplier(supplier);
            if (suppliervalidate)
            {
                suppliers.UpdateSupplierDetails(supplierId, supplier);
            }
            else
            {
                return "Enter Valid Validations";
            }
            return "Supplier Update Successfully";
        }
    }
}
