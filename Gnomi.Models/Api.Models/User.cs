using System;

namespace Gnomi.Models.Api.Models
{
    public class User
    {
        public User(long userId, string firstName, string lastName, DateTime dob, string gender, int zipcode)
        {

        }

        public long UserId { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public int Zipcode { get; set; }
    }
}
