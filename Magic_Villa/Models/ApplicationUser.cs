using Microsoft.AspNetCore.Identity;

namespace Magic_Villa.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
