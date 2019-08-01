using gnomi.dataService.entities;
using System.Collections.Generic;

namespace gnomi.dataService.metadata
{ 
    public interface iMetadata<key>
    {
        void refresh(iEntity<key> entity);

        string name { get; }

        string parameterNames { get; }

        string attributeNames { get; }

        IEnumerable<string> getAttributeNames { get; }
    }
}
