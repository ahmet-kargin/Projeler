﻿// <auto-generated />
using CinemaApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaApp.Data.Migrations
{
    [DbContext(typeof(FilmAppContext))]
    partial class FilmAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("CinemaApp.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Komedi"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Aile"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Korku"
                        });
                });

            modelBuilder.Entity("CinemaApp.Entity.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DirectorName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilmDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.HasKey("FilmId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 1",
                            Poster = "url"
                        },
                        new
                        {
                            FilmId = 2,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 2",
                            Poster = "url"
                        },
                        new
                        {
                            FilmId = 3,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 3",
                            Poster = "url"
                        },
                        new
                        {
                            FilmId = 4,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 4",
                            Poster = "url"
                        },
                        new
                        {
                            FilmId = 5,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 5",
                            Poster = "url"
                        },
                        new
                        {
                            FilmId = 6,
                            DirectorName = "Şahan GÖKBAKAR",
                            Duration = 120,
                            FilmDescription = "Sevgilinizle izlemeyin!!!",
                            FilmName = "Recep İvedik 6",
                            Poster = "url"
                        });
                });

            modelBuilder.Entity("CinemaApp.Entity.FilmCategory", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("FilmCategories");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            FilmId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            FilmId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            FilmId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            FilmId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            FilmId = 4,
                            CategoryId = 1
                        },
                        new
                        {
                            FilmId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            FilmId = 6,
                            CategoryId = 2
                        });
                });

            modelBuilder.Entity("CinemaApp.Entity.FilmCategory", b =>
                {
                    b.HasOne("CinemaApp.Entity.Category", "Category")
                        .WithMany("FilmCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaApp.Entity.Film", "Film")
                        .WithMany("FilmCategories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("CinemaApp.Entity.Category", b =>
                {
                    b.Navigation("FilmCategories");
                });

            modelBuilder.Entity("CinemaApp.Entity.Film", b =>
                {
                    b.Navigation("FilmCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
