﻿// <auto-generated />
using System;
using GameRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameRental.Data.Migrations
{
    [DbContext(typeof(GameRentalDbContext))]
    [Migration("20200526120509_AddedGameGenreRelationshipToGameGenrePivotTable")]
    partial class AddedGameGenreRelationshipToGameGenrePivotTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GameRental.Core.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverArtUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(0)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(0)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<Guid>("Ref")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(0)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(0)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverArtUrl = "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg",
                            CreatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(650),
                            Description = "Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]",
                            Name = "Uncharted: Drake's Fortune",
                            PublisherId = 1,
                            Ref = new Guid("0a811243-c7a4-4a72-aff7-a42c84255cd2"),
                            ReleaseDate = new DateTime(2007, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(1090)
                        },
                        new
                        {
                            Id = 2,
                            CoverArtUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Crash_Bandicoot_Cover.png",
                            CreatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(2050),
                            Description = "Crash Bandicoot is a platform video game developed by Naughty Dog and published by Sony Computer Entertainment for the PlayStation. The game was released in North America in September 1996, and in Europe in November 1996.",
                            Name = "Crash Bandicoot",
                            PublisherId = 1,
                            Ref = new Guid("c3016508-09af-4921-82c9-fd9c81cfec49"),
                            ReleaseDate = new DateTime(1996, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 379, DateTimeKind.Local).AddTicks(2070)
                        });
                });

            modelBuilder.Entity("GameRental.Core.Models.GameGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Third Person Shooter"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Platformer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Horror"
                        });
                });

            modelBuilder.Entity("GameRental.Core.Models.GameGenrePivot", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenresPivot");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 3
                        });
                });

            modelBuilder.Entity("GameRental.Core.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(0)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(0)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 368, DateTimeKind.Local).AddTicks(2050),
                            Name = "Sony Interactive Entertainment",
                            UpdatedAt = new DateTime(2020, 5, 26, 14, 5, 9, 378, DateTimeKind.Local).AddTicks(5370)
                        });
                });

            modelBuilder.Entity("GameRental.Core.Models.Game", b =>
                {
                    b.HasOne("GameRental.Core.Models.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameRental.Core.Models.GameGenrePivot", b =>
                {
                    b.HasOne("GameRental.Core.Models.Game", "Game")
                        .WithMany("Genres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameRental.Core.Models.GameGenre", "Genre")
                        .WithMany("Genres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
