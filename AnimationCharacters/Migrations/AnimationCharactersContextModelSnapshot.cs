﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AnimationCharacters.Data;

namespace AnimationCharacters.Migrations
{
    [DbContext(typeof(AnimationCharactersContext))]
    partial class AnimationCharactersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimationCharacters.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryCharacter")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameCharacter")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Scenery")
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleMovie")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
