using Microsoft.AspNetCore.Identity;

namespace Bouba_Store.Models.Domain
{
    public class ApplicationUser:IdentityUser

    {
       public String? Name{ get; set; }
        
    }
}
