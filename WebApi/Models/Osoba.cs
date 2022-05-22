using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace WebApi.Models
{
    public partial class Osoba
    {
        public Osoba()
        {
            Donacijas = new HashSet<Donacija>();
            HistorijaBolestis = new HashSet<HistorijaBolesti>();
        }
        [Required, StringLength(20, ErrorMessage ="JMBG ne može sadržavati više od 20 karaktera")]
        public string Jmbg { get; set; }
        [Required, StringLength(50, ErrorMessage = "Ime ne može sadržavati više od 50 karaktera")]
        public string Ime { get; set; }
        [Required, StringLength(50, ErrorMessage = "Prezime ne može sadržavati više od 50 karaktera")]
        public string Prezime { get; set; }
        [Required, StringLength(20, ErrorMessage = "Broj knjižice ne može sadržavati više od 20 karaktera")]
        public string BrojKnjizice { get; set; }
        [Required, StringLength(100, ErrorMessage = "Adresa ne može sadržavati više od 100 karaktera")]
        public string Adresa { get; set; }
        [Required]
        [Range(1, 9)]
        public int OpcinaId { get; set; }
        [Required]
        [Range (1, 8)]
        public int KrvnaGrupaId { get; set; }
        [Required]
        [Range(1, 2)]
        public int FaktorId { get; set; }
        [Required, StringLength(100, ErrorMessage = "Telefon ne može sadržavati više od 100 karaktera")]
        public string Telefon { get; set; }

        [StringLength(100, ErrorMessage = "Email ne može sadržavati više od 100 karaktera")]
        public string Email { get; set; }
        [StringLength(255, ErrorMessage = "Napomena ne može sadržavati više od 255 karaktera")]
        public string Napomena { get; set; }

        public virtual RhFaktor Faktor { get; set; }
        public virtual KrvnaGrupa KrvnaGrupa { get; set; }
        public virtual Opcina Opcina { get; set; }
        public virtual ICollection<Donacija> Donacijas { get; set; }
        public virtual ICollection<HistorijaBolesti> HistorijaBolestis { get; set; }
    }
}
