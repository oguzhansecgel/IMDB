﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231103145028_rated-added")]
    partial class ratedadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KATEGORI_ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("KATEGORI_ADI")
                        .HasColumnOrder(2);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Aksiyon"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Komedi"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Romantik"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Korku"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("YONETMEN_ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorID"), 1L, 1);

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("YONETMEN_ADI")
                        .HasColumnOrder(2);

                    b.Property<string>("DirectorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("YONETMEN_SOYADI")
                        .HasColumnOrder(3);

                    b.HasKey("DirectorID");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            DirectorID = 1,
                            DirectorName = "Şahan",
                            DirectorSurname = "Gökbahar"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FILM_ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("FilmDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("FILM_ACIKLAMASI")
                        .HasColumnOrder(3);

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FILM_ADI")
                        .HasColumnOrder(2);

                    b.Property<int>("FilmRated")
                        .HasColumnType("int");

                    b.Property<int>("FilmYear")
                        .HasColumnType("int")
                        .HasColumnName("FILM_CIKIS_SENESİ")
                        .HasColumnOrder(4);

                    b.HasKey("FilmId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            CategoryId = 2,
                            DirectorId = 1,
                            FilmDescription = "Deneme Deneme Deneme Deneme",
                            FilmName = "Recep İvedik 1 ",
                            FilmRated = 0,
                            FilmYear = 2008
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Film", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("FilmId")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Director", "Director")
                        .WithMany("FilmId")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("FilmId");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Director", b =>
                {
                    b.Navigation("FilmId");
                });
#pragma warning restore 612, 618
        }
    }
}
