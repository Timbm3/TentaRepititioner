using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tenta_1_1.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }


        [Required]
        [IdiotValidation]
        [StringLength(25, ErrorMessage = "Should be shorter than 25 characters")]
        public string Titel { get; set; }


        [Required]
        [Range(1,14.5, ErrorMessage = "Should be between 1 and 14,5 minutes")]
        [DataType(DataType.Duration)]
        public double Duration { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }

    }
}
