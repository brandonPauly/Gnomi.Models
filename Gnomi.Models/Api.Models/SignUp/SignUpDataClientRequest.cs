using System.ComponentModel.DataAnnotations;


namespace Gnomi.Models.Api.Models.Requests
{
    public class SignUpDataClientRequest
    {
        [StringLength(254)]
        public string Email { get; set; }

        [StringLength(43)]
        public string Password { get; set; }
    }
}
