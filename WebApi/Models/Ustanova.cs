using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApi.Models
{
    public partial class Ustanova
    {
        public Ustanova()
        {
            Donacijas = new HashSet<Donacija>();
        }

        public int UstanovaId { get; set; }
        
        [Required,StringLength(255, ErrorMessage ="Naziv ustanove ne može sadržavati više od 255 karaktera")]
        public string NazivUstanove { get; set; }
        [Required]
        [Range(1,9)]
        public int OpcinaId { get; set; }

        public virtual Opcina Opcina { get; set; }
        public virtual ICollection<Donacija> Donacijas { get; set; }
    }
}
