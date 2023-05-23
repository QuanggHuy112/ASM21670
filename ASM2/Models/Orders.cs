using System.ComponentModel.DataAnnotations;

namespace ASM2.Models
{
    public class Orders
    {
        public int Id { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Fullname")]
        public string Fullname { get; set; }


        [Display(Name = "CartItem")]
        public string CartItem { get; set; }

        [Display(Name = "Total")]
        public double? Total { get; set; }

        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Display(Name = "Order date")]
        public DateTime? Orderdate { get; set; }
    }
}
