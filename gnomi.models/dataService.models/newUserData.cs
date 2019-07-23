using System.ComponentModel.DataAnnotations;

namespace gnomi.dataService.models
{
    public class newUserData
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(500)]
        public string passwordHash { get; set; }
    }
}
