using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{

  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TZ { get; set; }
    public DateTime BornDate { get; set; }
    public string Gender { get; set; }
    public string HMO { get; set; }
    public int FamilyCode { get; set; }
    public string StatusUser { get; set; }
    public string SpouseOrParentTZ { get; set; }
  }
}
