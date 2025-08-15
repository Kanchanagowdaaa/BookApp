using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Book.Model
{
    public class BookDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]      
        public int ID { get; set; }

        [Required]
        [StringLength(35)]
        public string BookName { get; set; }

        [Required]
        [StringLength(35)]
        public string Genre { get; set; }
        public bool AvailabilityStatus {  get; set; }
    }
}
