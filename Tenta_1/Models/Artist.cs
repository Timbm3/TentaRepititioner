using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Tenta_1_1.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Should be shorter than 25 characters")]
        public string Name { get; set; }


        [Required]
        [Range(1,99, ErrorMessage = "Must be between 1 and 99 years of age")]
        public int Age { get; set; }


        [StringLength(30, MinimumLength = 2, ErrorMessage = "Should be between 2 and 30 characters")]
        public string Band { get; set; }


        public IList<Song> Songs { get; set; }
    }
}