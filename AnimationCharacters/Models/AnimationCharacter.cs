using System;
using System.ComponentModel.DataAnnotations;

namespace AnimationCharacters.Models
{
    public class AnimationCharacter
    {
        public int ID { get; set; }
        public string TitleMovie { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Age { get; set; }
        public string Scenery { get; set; }
        public string Category { get; set; }
    }
}