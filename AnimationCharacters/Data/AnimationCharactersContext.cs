using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimationCharacters.Models;

    public class AnimationCharactersContext : DbContext
    {
        public AnimationCharactersContext (DbContextOptions<AnimationCharactersContext> options)
            : base(options)
        {
        }

        public DbSet<AnimationCharacters.Models.AnimationCharacter> AnimationCharacter { get; set; }
    }
