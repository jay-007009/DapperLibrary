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
    public class BookDetailController : ControllerBase
    {
        private readonly IBookDetails _bookdetails;
        public BookDetailController(IBookDetails bookdetail)
        {
            _bookdetails = bookdetail;
        }
        // GET: api/<BookDetailController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookDetailController>/5
        [HttpGet("{id}")]
        public DapperLibrary.DTO.BookDetails Get(int id)
        {
            return _bookdetails.GetBookById(id);

        }

        // POST api/<BookDetailController>
        [HttpPost]
        public void Post([FromBody] BookDetails bookdetails)
        {
            _bookdetails.AddBookDetails(bookdetails);

        }

        // PUT api/<BookDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BookDetails bookDetails)
        {
            _bookdetails.UpdateBookDetails(id, bookDetails);
        }

        // DELETE api/<BookDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookdetails.DeleteBook(id);
        }
    }
}
