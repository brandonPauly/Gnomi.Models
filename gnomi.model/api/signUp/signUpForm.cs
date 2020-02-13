using System.ComponentModel.DataAnnotations;

namespace gnomi.model.api.signUp
{
    public class signUpForm
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }
    }
}
