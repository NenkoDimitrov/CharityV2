using CharityV2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharityV2.Models
{
    public class ActivityVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public List<SelectList> User { get; set; }
        public string EmployeeId { get; set; }
        public List<SelectList> Employee { get; set; }
        public string CategoryId { get; set; }
        public List<SelectList> Category { get; set; }
        public string Description { get; set; }
        public char Place { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime RedistrationTime { get; set; }
        public string Photo { get; set; }
        public int CountInterest { get; set; }
        public int CountParticipants { get; set; }
        public StatusType Status { get; set; }
        [Required(ErrorMessage = "Избери снимка от компютъра си...")]
        public List<IFromFile> ImagePath { get; set; }
    }
}
