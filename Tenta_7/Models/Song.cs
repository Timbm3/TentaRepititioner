﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_7.Models
{
    public class Song
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public double Duration { get; set; }

        public string Genre { get; set; }
    }
}
