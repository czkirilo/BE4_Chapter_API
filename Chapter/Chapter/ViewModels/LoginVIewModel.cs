using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModels
{
    public class LoginVIewModel
    {
        [Required(ErrorMessage = "Email Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Requerida")]
        public string Senha { get; set; }   
    }
}
