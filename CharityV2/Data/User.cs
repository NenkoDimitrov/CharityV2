using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CharityV2.Data
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string Familyname { get; set; }
        public RoleType Role { get; set; }
        public ICollection<Activitiy> Activities { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
