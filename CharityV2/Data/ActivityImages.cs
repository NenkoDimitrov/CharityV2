using System;
using System.ComponentModel.DataAnnotations;

namespace CharityV2.Data
{
    public class ActivityImages
    {
        public ActivityImages()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        public string ImagePath { get; set; }
        //wrazka M:1
        [Required]
        public int ActivityId { get; set; }
        public Activitiy Activitiy { get; set; }
    }
}
