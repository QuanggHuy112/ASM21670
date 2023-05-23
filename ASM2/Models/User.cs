using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ASM2.Models
{
    public class User : IdentityUser
    {
       
        public string FullName { get; set; }
        
    }
}
