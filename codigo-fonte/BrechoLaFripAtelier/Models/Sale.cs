using System.ComponentModel.DataAnnotations;

namespace BrechoLaFripAtelier.Models
{
    public class Sale
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        public int ProductId { get; set; }

        [Display(Name = "Produto")]
        public Product? Product { get; set; }

        [Display(Name = "Data de Venda")]
        [Required(ErrorMessage = "Informe a data de venda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfSale { get; set; }

        [Display(Name = "Pagamento da Comissão")]
        [Required(ErrorMessage = "Informe o status de pagamento da comissão")]
        public CommissionStatus Status { get; set; }
    }

    public enum CommissionStatus
    {
        Pendente,
        Pago,
        Indisponível
    }
}
