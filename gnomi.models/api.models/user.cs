using System;
using System.Collections.Generic;

namespace gnomi.api.models
{
    public class user
    {
        public user(string _userId_)
        {
            userId = _userId_;
            facets = new List<facet>();
        }

        public string userId { get; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string gender { get; set; }

        public string zipcode { get; set; }

        public IEnumerable<facet> facets { get; }
    }
}