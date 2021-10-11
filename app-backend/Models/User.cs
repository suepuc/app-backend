using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace app_backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Required(ErrorMessage = "Informe o email!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe o nome!")]
        [Display(Name = "Nome de usuário")]
        public string nomeDeUsuario { get; set; }

        [Display(Name = "Logueado")]
        public bool estaLogueado { get; set; } = true;

        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        Usuario
    }
}
