using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name ="Ürün Id")]
        public int ProductId { get; set; }
        [Display(Name ="Ürün Adı")]
        [Required]
        public string? Name { get; set; }
        [Display(Name ="Ürün Fiyatı")]
        public decimal Price { get; set; }
        [Display(Name ="Resim")]
        public string? Image { get; set; }

        public string? Despcription { get; set; }
        [Display(Name ="IsActive")]
        public bool IsActive { get; set; }
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
    }
}