using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Web;

namespace Movly.Models
{
    public class Movie
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId{ get; set; }

        public Movie()
        {
            Id = 0;
        }
    }
}