
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Cignal.AOTool.WebApp.Data.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        
    }
}