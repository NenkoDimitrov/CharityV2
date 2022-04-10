using System.Collections.Generic;

namespace CharityV2.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Familyname { get; set; }
        public char Phone { get; set; }
        public char Email { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public RoleType Role { get; set; }
        public ICollection<Activitiy> Activities { get; set; }
    }
}
