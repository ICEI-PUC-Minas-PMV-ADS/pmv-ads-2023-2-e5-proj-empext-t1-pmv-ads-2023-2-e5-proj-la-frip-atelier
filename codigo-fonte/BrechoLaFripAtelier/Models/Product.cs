using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrechoLaFripAtelier.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Tamanho")]
        [Required(ErrorMessage = "Informe o tamanho do produto")]
        public string Size { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe o preço do produto")]
        [Column(TypeName = "decimal(12, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Parceira")]
        public int PartnerId { get; set; }

        [Display(Name = "Parceira")]
        public Partner? Partner { get; set; }

        [Display(Name = "Status do Produto")]
        [Required(ErrorMessage = "Informe o status do produto")]
        public ProductStatus Status { get; set; }

        public List<Sale> Sales { get; set; } = new();
    }

    public enum ProductStatus
    {
        Disponível,
        Vendido
    }
}
