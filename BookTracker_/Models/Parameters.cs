using System.ComponentModel.DataAnnotations;

namespace BookTracker_.Models
{
    public class Parameters
    {
        [Required]
        public string Name { get; set; } = null!;
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
