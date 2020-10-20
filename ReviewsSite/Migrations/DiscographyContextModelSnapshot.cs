﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(DiscographyContext))]
    partial class DiscographyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Early Career",
                            Description = "1963",
                            Image = "PleasePleaseMe.jpg",
                            Name = "Please Please Me"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Early Career",
                            Description = "1964",
                            Image = "MeettheBeatles.jpg",
                            Name = "Meet the Beatles"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Early Career",
                            Description = "1964",
                            Image = "HardDaysNight.jpg",
                            Name = "Hard Day's Night"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Early Career",
                            Description = "1964",
                            Image = "BeatlesforSale.jpg",
                            Name = "Beatles for Sale"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Mid-Career",
                            Description = "1965",
                            Image = "Help!.jpg",
                            Name = "Help!"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Mid-Career",
                            Description = "1965",
                            Image = "RubberSoul.jpg",
                            Name = "Rubber Soul"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Mid-Career",
                            Description = "1966",
                            Image = "Revolver.jpg",
                            Name = "Revolver"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Late Career",
                            Description = "1967",
                            Image = "SgtPepper.jpg",
                            Name = "Sgt. Pepper's Lonely Hearts Club Band"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Late Career",
                            Description = "1967",
                            Image = "MagicalMysteryTour.jpg",
                            Name = "Magical Mystery Tour"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Late Career",
                            Description = "1968",
                            Image = "WhiteAlbum.jpg",
                            Name = "White Album"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Late Career",
                            Description = "1969",
                            Image = "YellowSubmarine.jpg",
                            Name = "Yellow Submarine"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Late Career",
                            Description = "1969",
                            Image = "AbbeyRoad.jpg",
                            Name = "Abbey Road"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Late Career",
                            Description = "1970",
                            Image = "LetItBe.jpg",
                            Name = "Let It Be"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(160)")
                        .HasMaxLength(160);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 1,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 2,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 2,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 2,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 2,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 3,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 3,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 3,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 3,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 13,
                            AlbumId = 4,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 14,
                            AlbumId = 4,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 15,
                            AlbumId = 4,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 16,
                            AlbumId = 4,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 17,
                            AlbumId = 5,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 18,
                            AlbumId = 5,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 19,
                            AlbumId = 5,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 20,
                            AlbumId = 5,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 21,
                            AlbumId = 6,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 22,
                            AlbumId = 6,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 23,
                            AlbumId = 6,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 24,
                            AlbumId = 6,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 25,
                            AlbumId = 7,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 26,
                            AlbumId = 7,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 27,
                            AlbumId = 7,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 28,
                            AlbumId = 7,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 29,
                            AlbumId = 8,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 30,
                            AlbumId = 8,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 31,
                            AlbumId = 8,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 32,
                            AlbumId = 8,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 33,
                            AlbumId = 9,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 34,
                            AlbumId = 9,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 35,
                            AlbumId = 9,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 36,
                            AlbumId = 9,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 37,
                            AlbumId = 10,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 38,
                            AlbumId = 10,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 39,
                            AlbumId = 10,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 40,
                            AlbumId = 10,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 41,
                            AlbumId = 11,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 42,
                            AlbumId = 11,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 43,
                            AlbumId = 11,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 44,
                            AlbumId = 11,
                            Content = "This album is really great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 45,
                            AlbumId = 12,
                            Content = "This album is good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 46,
                            AlbumId = 12,
                            Content = "This album is really good.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 47,
                            AlbumId = 12,
                            Content = "This album is great.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 48,
                            AlbumId = 12,
                            Content = "This album is real.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        },
                        new
                        {
                            Id = 49,
                            AlbumId = 13,
                            Content = "This album is awesome because I wrote most of it",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Paul McCartney"
                        },
                        new
                        {
                            Id = 50,
                            AlbumId = 13,
                            Content = "This album is really good, bro.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "John Lennon"
                        },
                        new
                        {
                            Id = 51,
                            AlbumId = 13,
                            Content = "This album is cool, man.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "George Harrison"
                        },
                        new
                        {
                            Id = 52,
                            AlbumId = 13,
                            Content = "This album is fine but we had to sue Paul to get it out.",
                            Rating = 5,
                            ReviewDate = "10/15/2020",
                            ReviewerName = "Ringo Starr"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Album", "Album")
                        .WithMany("Reviews")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
