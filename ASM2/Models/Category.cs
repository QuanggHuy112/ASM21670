using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace ASM2.Models
{
    public class Category
    {   [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter desciption")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
