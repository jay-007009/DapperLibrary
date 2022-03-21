using DapperLibrary.BLL;
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
    public class MembersController : ControllerBase
    {
        private readonly IMembersBAL _members;
        public MembersController(IMembersBAL members)
        {
            _members = members;
        }
  
        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public LibraryMembers Get(int id)
        {
        return _members.GetMemberById(id);
            
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] LibraryMembers member)
        {
            _members.ADDMembers(member);
           
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LibraryMembers member)
        {
            _members.UpdateMemberDetails(id, member);
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _members.DeleteMember(id);
        }
    }
}
