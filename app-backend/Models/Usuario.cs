using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a senha!")]
        public string senha { get; set; }

        [Required(ErrorMessage = "Informe o email!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe o nome!")]
        [Display(Name = "Nome de usuário")]
        public string nomeDeUsuario { get; set; }

        public bool estaLogueado { get; set; } = true;

    }
}
