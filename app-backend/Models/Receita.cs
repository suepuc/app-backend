using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_backend.Models
{      
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Id{ get; set; }

        [Display(Name = "Autor")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
