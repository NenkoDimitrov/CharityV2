using CharityV2.Data;
using System.Collections.Generic;

namespace CharityV2.Models
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Activitiy> Activities { get; set; }
    }
}
