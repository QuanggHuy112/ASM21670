using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ASM2.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM2.ViewModels
{
    public class BookViewModel
    {

        [Required(ErrorMessage = "Please enter title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter release date")]
        [Display(Name = "Release Date")]

        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public double Price { get; set; }

        [NotMapped]
        public string Image { get; set; }

         [Display(Name = "CategoryId")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } 
        
       
    }
}
