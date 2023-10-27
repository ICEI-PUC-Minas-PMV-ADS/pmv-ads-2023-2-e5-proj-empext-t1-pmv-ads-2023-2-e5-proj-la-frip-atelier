using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BrechoLaFripAtelier.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "Informe o username")]
        public string Username { get; set; } = string.Empty;

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a senha")]
        [MinLength(8, ErrorMessage = "A senha deve ter mais que 8 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Pergunta de Segurança")]
        [Required(ErrorMessage = "Informe a pergunta de segurança")]
        public string SecurityQuestion { get; set; } = string.Empty;

        [Display(Name = "Resposta de Segurança")]
        [Required(ErrorMessage = "Informe a resposta para a pergunta")]
        public string SecurityResponse { get; set; } = string.Empty;
    }
}
