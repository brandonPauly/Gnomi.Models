

namespace gnomi.dataService.metadata
{ 
    public interface iMetadata<key>
    {
        string name { get; }

        string parameterNames { get; }

        string attributeNames { get; }
    }
}
