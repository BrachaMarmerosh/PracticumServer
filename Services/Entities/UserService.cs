using AutoMapper;
using Common.DTOs;
using Repositories.Entities;
using Repositories.Interfaces;

namespace Services.Entities
{
  public class UserService : IService<UserDTO>
  {
    private static int familyCounter = 1;
    private readonly IMapper _mapper;
    private readonly IdataRepository<User> _userRepository;
    public UserService(IMapper mapper, IdataRepository<User> userRepository)
    {
      _mapper = mapper;
      _userRepository = userRepository;
    }
    public async Task<UserDTO> Add(UserDTO entity)
    {
      var allUsers = await GetAll();
      var result = allUsers.FirstOrDefault(user => user.TZ == entity.SpouseOrParentTZ);//add familyCode 
      if (result != null)
        entity.FamilyCode = result.FamilyCode;
      else entity.FamilyCode = familyCounter++;
      var isExist = allUsers.FirstOrDefault(user => user.TZ == entity.TZ);//check if user  exist allready 
      if (isExist != null)
        return null;
      return _mapper.Map<UserDTO>(await _userRepository.Add(_mapper.Map<User>(entity)));
    }

    public async Task<List<UserDTO>> GetAll()
    {
      return _mapper.Map<List<UserDTO>>(await _userRepository.GetAll());
    }

    public async Task<UserDTO> GetByTZ(string TZ)
    {
      return _mapper.Map<UserDTO>(await _userRepository.GetByTZ(TZ));
    }
  }
}
