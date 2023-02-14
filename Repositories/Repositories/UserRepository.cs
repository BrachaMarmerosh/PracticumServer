using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
  internal class UserRepository : IdataRepository<User>
  {
    Icontext _context;
    public UserRepository(Icontext context)
    {
      _context = context;
    }
    public async Task<User> Add(User entity)
    {
      EntityEntry<User> newOne = _context.Users.Add(entity);
      await _context.SaveChangesAsync();
      return newOne.Entity;
    }

    public async Task<List<User>> GetAll()
    {
      return await _context.Users.ToListAsync();
    }

    public async Task<User> GetByTZ(string TZ)
    {
      return await _context.Users.FindAsync(TZ);
    }
  }
}
