using gnomi.dataService.metadata;

namespace gnomi.dataService.entities
{ 
    public class human<t> : iEntity<t>
    {
        public human(iHumanMetadata<t> metadata)
        {
            this.metadata = metadata;
        }

        public string email { get; set; }

        public string password { get; set; }

        public iMetadata<t> metadata { get; }
    }
}
