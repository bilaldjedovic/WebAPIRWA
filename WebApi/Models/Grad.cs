using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApi.Models
{
    public partial class Grad
    {
        public Grad()
        {
            Opcinas = new HashSet<Opcina>();
        }

        public int GradId { get; set; }
        [Required, StringLength(100,ErrorMessage ="Naziv grada ne može sadržavati više od 100 karaktera")]
        public string NazivGrada { get; set; }

        public virtual ICollection<Opcina> Opcinas { get; set; }
    }
}
