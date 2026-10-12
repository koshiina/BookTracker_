using System.ComponentModel.DataAnnotations;

namespace BookTracker_.Models
{//cia yra strong type in EF, mes is pradziu kuriam parametrus
 //sql lentelems, panaudojus kurias veliau panaudosim kuriant sql lentele(?)
    public class Parameters
    {
        [Required]
        public string Title{ get; set; } = null!;
        [Required]
        public string Author { get; set; } = null!;
        [Required]
        public int PageCount { get; set; }
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;
        //[Required]
        //public DateTime EndDate { get; set; } = DateTime.Today;
    }
}
