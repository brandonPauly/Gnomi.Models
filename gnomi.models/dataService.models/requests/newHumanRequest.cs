using System.ComponentModel.DataAnnotations;

namespace gnomi.dataService.requests
{
    public class newHumanRequest
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(500)]
        public string passwordHash { get; set; }
    }
}
