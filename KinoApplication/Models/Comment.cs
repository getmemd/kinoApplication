using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KinoApplication.Models
{
    public class Comment : IValidatableObject
    {
        [Required]
        [Display(Name = "Comment ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Comment length can't be more than 1000.")]
        [Display(Name = "Comment's text")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Movie's ID")]
        public int MovieId { get; set; }

        [Required]
        [Display(Name = "User's ID")]
        public string UsersId { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (Rating > 5 || Rating < 0 )
                yield return new ValidationResult("Rating cant be lower than 0 or bigger than 5!");
        }
    }
}
