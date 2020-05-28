using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ApplicationUserGymClass
    {
       // public int Id { get; set; }
        public int GymClassId { get; set; }
        public string ApplicationUserId { get; set; }
        public GymClass GymClass { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
