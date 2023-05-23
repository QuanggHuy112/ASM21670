using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM2.Models
{
    public class Book
    {
   
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter release date")]
        [Display(Name = "Release Date")]

        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public double Price { get; set; }      
        public string Image { get; set; }

        [Required(ErrorMessage = "Please enter category id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}
