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
    public class FineDetailsController : ControllerBase
    {
        private readonly IFineDetails _finedetails;
        public FineDetailsController(IFineDetails finedetail)
        {
            _finedetails = finedetail;
        }
        // GET: api/<FineDetailsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FineDetailsController>/5
        [HttpGet("{id}")]
        public LibraryFineDetails Get(string id)
        {
            return _finedetails.GetFineDetailsById(id);

        }

        // POST api/<FineDetailsController>
        [HttpPost]
        public void Post([FromBody] LibraryFineDetails finedetails)
        {
            _finedetails.AddFineDetails(finedetails);

        }

        // PUT api/<FineDetailsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] LibraryFineDetails finedetail)
        {
            _finedetails.UpdateFineDetails(id, finedetail);
        }

        // DELETE api/<FineDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _finedetails.DeleteFineDetails(id);
        }
    }
}
