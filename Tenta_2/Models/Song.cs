using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_2.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "sfdfsf") ]
        public string Titel { get; set; }

        [Range(1,14.5, ErrorMessage = "fsfsdfsdf")]
        public double Duration { get; set; }
        public string Genre { get; set; }


    }
}
