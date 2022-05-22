using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApi.Models
{
    public partial class Donacija
    {
        public int DonacijaId { get; set; }
        [Required, StringLength(20, ErrorMessage = "JMBG ne može sadržavati preko 20 karaktera")]
        public string Jmbg { get; set; }

        [Required]
        [Range(1,9)]
        public int UstanovaId { get; set; }
        [Required]
        public DateTime Datum { get; set; }

        [StringLength(255, ErrorMessage = "Opis ne može sadržavati više od 255 karaktera")]
        public string Opis { get; set; }

        public virtual Osoba JmbgNavigation { get; set; }
        public virtual Ustanova Ustanova { get; set; }
    }
}
