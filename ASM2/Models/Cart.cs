using System.ComponentModel.DataAnnotations;

namespace ASM2.Models
{
    public class Cart
    {
        public Book Books { get; set; }
        public int Quantity { get; set; }
    }
}
