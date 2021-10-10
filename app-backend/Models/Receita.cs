
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

        [Required(ErrorMessage = "Informe o nome da receita!")]
        [Display(Name = "Nome da Receita")]
        public string titulo { get; set; }

        [Display(Name = "Curtidas")]
        public int contadorFavoritos { get; set; } = 0;

        [Required(ErrorMessage = "Informe o tempo aproximado de preparo!")]
        [Display(Name = "Tempo de Preparo")]
        public int tempoDePreparo { get; set; }

        [Required(ErrorMessage = "Informe as instruções de preparo!")]
        [Display(Name = "Instruções de Preparo")]
        public string modoDePreparo{ get; set; }

        [Display(Name = "Criada em")]
        public DateTime dataDeCriacao { get; set; } = DateTime.UtcNow;
    }
}
