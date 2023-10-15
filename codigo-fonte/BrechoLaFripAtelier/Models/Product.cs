using System.ComponentModel.DataAnnotations;

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
        public int Price { get; set; }

        public DateTime DateOfSale { get; set; }

        [Display(Name = "Parceira")]
        public int PartnerId { get; set; }

        public Partner? Partner { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Informe o status do produto")]
        public ProductStatus Status { get; set; }
    }

    public enum ProductStatus
    {
        Disponível,
        Vendido
    }
}
