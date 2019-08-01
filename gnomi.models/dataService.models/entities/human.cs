using gnomi.dataService.metadata;
using System;

namespace gnomi.dataService.entities
{ 
    public class human<t> : iEntity<t>
    {
        private iMetadata<t> _metadata;
        public human(iHumanMetadata<t> metadata)
        {
            _metadata = metadata;
        }

        public string email { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime? dateOfBirth { get; set; }

        public string zipcode { get; set; }

        public byte? genderId { get; set; } 

        public iMetadata<t> metadata {
            get {
                _metadata.refresh(this);
                return _metadata;
            }
        }
    }
}
