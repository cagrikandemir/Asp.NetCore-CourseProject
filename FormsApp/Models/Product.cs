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
        [Required]
        public decimal? Price { get; set; }
        [Display(Name ="Resim")]
        public string? Image { get; set; }
        [Required]
        public string? Despcription { get; set; }
        [Display(Name ="IsActive")]
        public bool IsActive { get; set; }
        [Display(Name ="Category")]
        [Required]
        public int? CategoryId { get; set; }
    }
}