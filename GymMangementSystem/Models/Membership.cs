using System.ComponentModel.DataAnnotations.Schema;

namespace GymMangementSystem.Models
{
    public class Membership:BaseEntity   
    
    {

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MemberId { get; set; }

        public int PlanId { get; set; }

        public Member Member { get; set; } = null!;

        public Plan Plan { get; set; } = null!;


        [NotMapped]
        public string Status =>
            EndDate > DateTime.Now ? "Active" : "Expired";

        [NotMapped]
        public bool IsActive =>
            EndDate > DateTime.Now;
    }
}
