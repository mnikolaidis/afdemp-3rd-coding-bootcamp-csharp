using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesGallery.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Release")]
        public DateTime ReleaseDateTime { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
