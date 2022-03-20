using System.Collections.Generic;

namespace CharityV2.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Activitiy> Activities{ get; set; }
    }
}
