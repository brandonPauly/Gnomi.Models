using System;
using System.Collections.Generic;

namespace Gnomi.Api.Models
{
    public class User
    {
        public User(long userId)
        {
            UserId = userId;
            Facets = new List<Facet>();
        }

        public long UserId { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Zipcode { get; set; }

        public IEnumerable<Facet> Facets { get; }
    }
}
