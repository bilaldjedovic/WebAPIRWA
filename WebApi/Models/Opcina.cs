using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace WebApi.Models
{
    public partial class Opcina
    {
        public Opcina()
        {
            Osobas = new HashSet<Osoba>();
            Ustanovas = new HashSet<Ustanova>();
        }
   
        public int OpcinaId { get; set; }
        [Required, StringLength(100, ErrorMessage = "Naziv općine ne može sadržavati više od 100 karaktera")]
        public string NazivOpcine { get; set; }

        [Required]
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Osoba> Osobas { get; set; }
        public virtual ICollection<Ustanova> Ustanovas { get; set; }
    }
}
