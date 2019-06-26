namespace Gnomi.Api.Models
{
    public class Facet
    {
        public Facet(long facetId, string tag, long connections)
        {
            FacetId = facetId;
            Tag = tag;
            Connections = connections;
        }

        public long FacetId { get; }

        public string Tag { get; }

        public long Connections { get; }
    }
}
