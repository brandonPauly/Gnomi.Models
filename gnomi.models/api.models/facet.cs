namespace gnomi.api.models
{
    public class facet
    {
        public facet(string _facetId_, string _tag_, long _connections_)
        {
            this.facetId = _facetId_;
            this.tag = _tag_;
            this.connections = _connections_;
        }

        public string facetId { get; }

        public string tag { get; }

        public long connections { get; }
    }
}
