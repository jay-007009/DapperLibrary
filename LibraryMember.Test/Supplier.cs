using DapperLibrary.DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LibraryMember.Test
{
   public class Supplier
    {
        public Mock<DapperLibrary.DAL.Supplier> _service = new Mock<DapperLibrary.DAL.Supplier>();


        //Insert Suppliers Unit Test
        [Fact]
        public void AddMembers()
        {
            _service.Setup(options => options.AddSupplier(It.IsAny<Suppliers>()));
            var actualresult = _service.Object.AddSupplier(InsertSupplier());
            Assert.True(true, actualresult);
        }

        public Suppliers InsertSupplier()
        {
            return new DapperLibrary.DTO.Suppliers
            {
                SupplierName = "Ramesh",
                SupplierAddress = "Navsarihighschool",
                SupplierCity = "Navsari",
                SupplierPincode = 396445,
                SupplierContact = "4561237890",
                SupplierEmail = "jayr002@gmail.com"
              
            };
        }



        //Update Supplier Unit Test
        [Fact]
        public void UpdateSuppliers()
        {
            _service.Setup(options => options.UpdateSupplierDetails(It.IsAny<int>(), It.IsAny<DapperLibrary.DTO.Suppliers>()));
            var actualresult = _service.Object.UpdateSupplierDetails(1, SupplierUpdate());
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.Suppliers SupplierUpdate()
        {
            return new DapperLibrary.DTO.Suppliers
            {
                SupplierId = 1,
                SupplierName = "Ramesh",
                SupplierAddress = "Navsarihighschool",
                SupplierCity = "Navsari",
                SupplierPincode = 396445,
                SupplierContact = "4561237890",
                SupplierEmail = "jayr002@gmail.com"
            };
        }

        //Delete Supplier Unit Test
        [Fact]
        public void DeleteSupplier()
        {
            _service.Setup(options => options.DeleteSupplier(It.IsAny<int>()));
            var actualresult = _service.Object.DeleteSupplier(203);
            Assert.True(true, actualresult);
        }

        public DapperLibrary.DTO.Suppliers DeleteSupplierById(int id)
        {
            return new DapperLibrary.DTO.Suppliers
            {
                SupplierId = 203

            };
        }

        //Get Supplier Unit Test
        [Fact]
        public void GetForSupplier()
        {
            _service.Setup(options => options.GetSupplierById(It.IsAny<int>())).Returns(GetSupplierById());
            var actualresult = _service.Object.GetSupplierById(1);
            Assert.True(actualresult.SupplierId > 0);
        }

        public DapperLibrary.DTO.Suppliers GetSupplierById()
        {
            return new DapperLibrary.DTO.Suppliers
            {
                SupplierId = 203,

            };
        }
    }
}
