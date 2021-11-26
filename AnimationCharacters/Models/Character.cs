using System;
using System.ComponentModel.DataAnnotations;

namespace AnimationCharacters.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string TitleMovie { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string NameCharacter { get; set; }
        public string CategoryCharacter { get; set; }
        public string Scenery { get; set; }
    }
}