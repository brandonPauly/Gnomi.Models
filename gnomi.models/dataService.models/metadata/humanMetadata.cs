
namespace gnomi.dataService.metadata
{
    public class humanMetadata<t> : iHumanMetadata<t>
    {
        public string name => "human";
        public string parameterNames => "(@email, @password)";
        public string attributeNames => "(email, password)";
    }
}
