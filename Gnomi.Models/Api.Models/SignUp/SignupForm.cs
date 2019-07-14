using System.ComponentModel.DataAnnotations;

namespace Gnomi.Api.Models
{
    public class SignUpForm
    {
        [StringLength(254)]
        public string Email { get; set; }

        [StringLength(43)]
        public string Password { get; set; }
    }
}
