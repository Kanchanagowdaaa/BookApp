using System.ComponentModel.DataAnnotations;

namespace PAL_Book.Models
{
    public class Book
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Book name cannot be longer than 50 characters")]
        public string BookName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Genre cannot be longer than 20 characters")]
        public string Genre { get; set; }

        public bool AvailabilityStatus {  get; set; }
    }
}
