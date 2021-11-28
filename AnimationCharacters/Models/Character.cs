using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimationCharacters.Models
{
    public class Character
    {
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9\s-:?!ºª+&%#]*$")]
        [Display(Name = "Title")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string TitleMovie { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "1/1/2200")]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9\s-]*$")]
        [Display(Name = "Character")]
        [StringLength(30)]
        [Required]
        public string NameCharacter { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "Category")]
        [StringLength(20)]
        [Required]
        public string CategoryCharacter { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z/s-]*$")]
        [StringLength(30)]
        [Required]
        public string Scenery { get; set; }
    }
}