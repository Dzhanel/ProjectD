using System.ComponentModel.DataAnnotations;
using static ProjectD.Common.Constants.DataConstants.User;

namespace ProjectD.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        [Compare(nameof(PasswordRepeat))]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        public string PasswordRepeat { get; set; } = null!;

    }
}
