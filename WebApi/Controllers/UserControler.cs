using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : ControllerBase
    {
        private readonly IService<UserDTO> _user;

        public UserControler(IService<UserDTO> user)
        {
            _user = user;
        }
        // GET: api/<UserControler>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<UserControler>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<UserControler>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();
            newOne.TZ = postModel.TZ;
            newOne.BornDate = postModel.BornDate;
            newOne.FirstName = postModel.FirstName;
            newOne.LastName = postModel.LastName;
            newOne.Id = postModel.Id;
            newOne.Gender = postModel.Gender;
            newOne.HMO = postModel.HMO;
            newOne.FamilyCode = postModel.FamilyCode;
            newOne.StatusUser = postModel.StatusUser;
            return await _user.Add(newOne);
        }

        //// PUT api/<UserControler>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserControler>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }
}
