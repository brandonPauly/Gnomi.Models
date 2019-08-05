using System;

namespace gnomi.dataService.entities
{ 
    public class human<t> : iEntity<t>
    {
        public long humanId { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime? dateOfBirth { get; set; }

        public string zipcode { get; set; }

        public byte? genderId { get; set; }

        public DateTime? signUpDate { get; set; }
    }
}
