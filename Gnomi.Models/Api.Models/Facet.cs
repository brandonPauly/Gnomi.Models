namespace Gnomi.Api.Models
{
    public class Facet
    {
        public Facet(string facetId, string tag, long connections)
        {
            FacetId = facetId;
            Tag = tag;
            Connections = connections;
        }

        public string FacetId { get; }

        public string Tag { get; }

        public long Connections { get; }
    }
}
