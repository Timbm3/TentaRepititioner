using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta_2.Models
{
    public class Artist
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "efsdf")]
        public string Name { get; set; }

        [Required]
        [Range(1,99, ErrorMessage = "sdfsdgsdgs")]
        public int Age { get; set; }


        public string Band { get; set; }

        public IList<Song> Songs { get; set; }


    }
}