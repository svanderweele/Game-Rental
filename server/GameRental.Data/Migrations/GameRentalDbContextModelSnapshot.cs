﻿// <auto-generated />
using System;
using GameRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameRental.Data.Migrations
{
    [DbContext(typeof(GameRentalDbContext))]
    partial class GameRentalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(7990),
                            Description = "Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]",
                            Name = "Uncharted: Drake's Fortune",
                            PublisherId = 1,
                            Ref = new Guid("00000000-0000-0000-0000-000000000000"),
                            ReleaseDate = new DateTime(2007, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedAt = new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(8410)
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
                            CreatedAt = new DateTime(2020, 5, 26, 11, 0, 34, 282, DateTimeKind.Local).AddTicks(3370),
                            Name = "Sony Interactive Entertainment",
                            UpdatedAt = new DateTime(2020, 5, 26, 11, 0, 34, 292, DateTimeKind.Local).AddTicks(4740)
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
#pragma warning restore 612, 618
        }
    }
}
