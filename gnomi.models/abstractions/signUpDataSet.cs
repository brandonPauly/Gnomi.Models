using System.ComponentModel.DataAnnotations;

namespace gnomi.models.abstractions
{
    public abstract class signUpDataSet
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }
    }
}
