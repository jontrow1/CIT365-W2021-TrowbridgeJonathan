using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace MvcMovie.Models
{
    public class Movie
    {
        public Movie()
        { }

        public Movie(string title, DateTime releaseDate, decimal price, string genre, string rating, string imagePath)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Price = price;
            genreTest = genre;
            Rating = rating;
            ImagePath = imagePath;

            switch (genreTest)
            { 
                case "0": 
                    Genre = "Bibliography"; 
                    break; 
                case "1":
                    Genre = "Christmas"; 
                    break; 
                case "2":
                    Genre = "Comedy"; 
                    break; 
                case "3":
                    Genre = "Documentary"; 
                    break; 
                case "4":
                    Genre = "Drama"; 
                    break; 
                case "5":
                    Genre = "Fantasy"; 
                    break; 
                case "6":
                    Genre = "Historical Fiction"; 
                    break; 
                case "7":
                    Genre = "Horror"; 
                    break; 
                case "8":
                    Genre = "Kids";
                    break; 
                case "9":
                    Genre = "Romantic Comedy"; 
                    break;
            }
        }

        public Movie(int id, string title, DateTime releaseDate, decimal price, string genre, string rating, string imagePath)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            Price = price;
            genreTest = genre;
            Rating = rating;
            ImagePath = imagePath;

            switch (genreTest)
            {
                case "0":
                    Genre = "Bibliography";
                    break;
                case "1":
                    Genre = "Christmas";
                    break;
                case "2":
                    Genre = "Comedy";
                    break;
                case "3":
                    Genre = "Documentary";
                    break;
                case "4":
                    Genre = "Drama";
                    break;
                case "5":
                    Genre = "Fantasy";
                    break;
                case "6":
                    Genre = "Historical Fiction";
                    break;
                case "7":
                    Genre = "Horror";
                    break;
                case "8":
                    Genre = "Kids";
                    break;
                case "9":
                    Genre = "Romantic Comedy";
                    break;
            }
        }

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
        public string genreTest { get; set; }
                
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        public string ImagePath { get; set; }
    }

    public enum Genres
    {
        Bibliography,
        Christmas,
        Comedy,
        Documentary,
        Drama,
        Fantasy,
        [Display(Name = "Historical Fiction")]
        HistoricalFiction,
        Horror,
        Kids,
        [Display(Name = "Romantic Comedy")]
        RomanticComedy        
    }
}