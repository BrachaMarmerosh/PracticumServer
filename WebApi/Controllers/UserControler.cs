using AutoMapper;
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
    private readonly IMapper _mapper;

    public UserControler(IService<UserDTO> user, IMapper mapper)
    {
      _user = user;
      _mapper = mapper;
    }
    // GET: api/<UserControler>
    [HttpGet]
    public async Task<List<UserDTO>> Get()
    {
      return await _user.GetAll();
    }

    // GET api/<UserControler>/5
    [HttpGet("{tz}")]
    public async Task<UserDTO> GetByTZ(string TZ)
    {
      return await _user.GetByTZ(TZ);
    }

    // POST api/<UserControler>
    [HttpPost]
    public async Task<UserDTO> Post([FromBody] UserModel postModel)
    {
      var newOne = _mapper.Map<UserDTO>(postModel);
      return await _user.Add(newOne);
    }



  }
}
