﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Tur
    {
        [Key]
        public int TurId { get; set; }
        [StringLength(50)]
        public string TurAd { get; set; }
        [StringLength(50)]
        public string TurAdIng { get; set; }

        public ICollection<Cins> Cins { get; set; }

    }
}
