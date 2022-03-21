using DapperLibrary.BLL.IServices;
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
    public class BookIssueController : ControllerBase
    {
        private readonly IBookIssueBAL _bookissuedetails;
        public BookIssueController(IBookIssueBAL bookissuedetail)
        {
            _bookissuedetails = bookissuedetail;
        }

        // GET: api/<BookIssueController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookIssueController>/5
        [HttpGet("{id}")]
        public BookIssue Get(int id)
        {
            return _bookissuedetails.GetBookIssueById(id);

        }

        // POST api/<BookIssueController>
        [HttpPost]
        public void Post([FromBody] BookIssue bookissuedetails)
        {
            _bookissuedetails.AddBookIssue(bookissuedetails);

        }

        // PUT api/<BookIssueController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BookIssue bookissueDetails)
        {
            _bookissuedetails.UpdateBookIssueDetails(id, bookissueDetails);
        }

        // DELETE api/<BookIssueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookissuedetails.DeleteBookIssue(id);
        }
    }
}
