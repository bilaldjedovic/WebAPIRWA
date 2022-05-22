using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApi.Models
{
    public partial class HistorijaBolesti
    {
        public int DijagnozaId { get; set; }
        [Required, StringLength(20, ErrorMessage ="JMBG ne može sadržavati više od 20 karaktera")]
        public string Jmbg { get; set; }
        [Required, StringLength(255, ErrorMessage="Dijagnoza ne može sadržavati više od 255 karaktera")]
        public string Dijagnoza { get; set; }
        [Required]
        public DateTime Datum { get; set; }

        public virtual Osoba JmbgNavigation { get; set; }
    }
}
