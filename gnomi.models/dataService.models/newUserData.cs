using gnomi.models.abstractions;
using System.ComponentModel.DataAnnotations;

namespace gnomi.models.dataService.models
{
    public class newUserData : newUserDataSet
    {
        [StringLength(500)]
        public string password { get; set; }
    }
}
