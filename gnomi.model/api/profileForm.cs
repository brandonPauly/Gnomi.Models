using System;
using System.ComponentModel.DataAnnotations;

namespace gnomi.model.api
{
    public class profileForm
    {
        [StringLength(30)]
        public string profileName { get; set; }

        [StringLength(30)]
        public string firstName { get; set; }

        [StringLength(40)]
        public string lastName { get; set; }

        public DateTime dateOfBirth { get; set; }

        [StringLength(24)]
        public string gender { get; set; }

        [StringLength(16)]
        public string zipcode { get; set; }
    }
}
