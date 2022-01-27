using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTracker.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters")]
        public string Notes { get; set; }

    }
}
