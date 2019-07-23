using System.ComponentModel.DataAnnotations;

namespace gnomi.orchestration.models
{
    public class signUpData
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }
    }
}
