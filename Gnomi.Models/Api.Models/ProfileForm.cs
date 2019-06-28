using System;
using System.ComponentModel.DataAnnotations;

namespace Gnomi.Api.Models
{
    public class ProfileForm
    {
        [StringLength(30)]
        public string ProfileName { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(24)]
        public string Gender { get; set; }

        [StringLength(16)]
        public string Zipcode { get; set; }
    }
}
