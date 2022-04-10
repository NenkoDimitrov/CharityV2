using CharityV2.Data;
using System.Collections.Generic;

namespace CharityV2.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Familyname { get; set; }
        public char Phone { get; set; }
        public char Email { get; set; }
        public string Description { get; set; }
        public ICollection<Activitiy> Activities { get; set; }
    }
}
