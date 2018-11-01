using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Web;

namespace Movly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }
        [DisplayName("Number In Stock")]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId{ get; set; }

    }
}