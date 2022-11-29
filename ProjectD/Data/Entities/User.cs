using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static ProjectD.Common.Constants.DataConstants.User;

namespace ProjectD.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string LastName { get; set; } = null!;
    }
}