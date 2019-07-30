using gnomi.dataService.metadata;

namespace gnomi.dataService.entities
{
    public interface iEntity<key>
    {
        iMetadata<key> metadata { get; }
    }
}
