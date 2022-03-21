using DapperLibrary.BLL.IServices;
using DapperLibrary.DAL;
using DapperLibrary.DAL.IServices;
using DapperLibrary.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierBAL _suppliers;
        public SupplierController(ISupplierBAL supplier)
        {
            _suppliers = supplier;
        }

        // GET: api/<SupplierController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public Suppliers Get(int id)
        {
            return _suppliers.GetSupplierById(id);

        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post([FromBody] Suppliers supplier)
        {
            _suppliers.AddSupplier(supplier);

        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Suppliers supplier)
        {
            _suppliers.UpdateSupplierDetails(id, supplier);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _suppliers.DeleteSupplier(id);
        }
    }
}
