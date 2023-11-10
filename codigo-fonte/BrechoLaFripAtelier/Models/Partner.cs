using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BrechoLaFripAtelier.Models
{
    public class Partner
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Informe o nome")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Informe o telefone de contato")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[0-9])[0-9]{3}\-[0-9]{4}$",
            ErrorMessage = "Insira no formato: (xx) 9xxxx-xxxx")]
        public string Phone { get; set; } = string.Empty;

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Informe o documento CPF")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$",
            ErrorMessage = "Insira no formato: xxx.xxx.xxx-xx")]
        public string CPFnumber { get; set; } = string.Empty;

        [Display(Name = "Comissão")]
        [Required(ErrorMessage = "Informe o percentual da comissão")]
        [Range(0, 100.00, ErrorMessage = "Percentual inválido")]
        public decimal Commission { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
