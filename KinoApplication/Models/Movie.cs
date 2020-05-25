using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KinoApplication.Models
{
    public class Movie : IValidatableObject
    {
        [Required]
        [Display(Name = "Product ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title length can't be more than 100.")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Description length can't be more than 1000.")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Director's name length can't be more than 100.")]
        [Display(Name = "Director")]
        public string Director { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [Url]
        [Display(Name = "Poster")]
        public string Poster { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ReleaseDate.Year < 1894)
                yield return new ValidationResult("Its unreal");
        }
    }
}
