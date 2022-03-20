using System;

namespace CharityV2.Data
{
    public class Activitiy
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public char Place { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime RedistrationTime { get; set; }
        public string Photo { get; set; }
        public string CategoryId { get; set; }
        public  Category Category { get;set; }
        public int CountInterest { get; set; }
        public int CountParticipants { get; set; }
        public string Status { get; set; }

    }
}
