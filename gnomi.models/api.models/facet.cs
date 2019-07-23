namespace gnomi.api.models
{
    public class facet
    {
        public facet(string fId, string t, long conn)
        {
            facetId = fId;
            this.tag = t;
            this.connections = conn;
        }

        public string facetId { get; }

        public string tag { get; }

        public long connections { get; }
    }
}
