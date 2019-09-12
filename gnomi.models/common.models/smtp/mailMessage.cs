

namespace gnomi.common.models.smtp
{
    public class mailMessage
    {
        public string subject { get; set; }

        public string body { get; set; }

        public to to { get; set; }

        public from from { get; set; }
    }

    public class to
    {
        public string name { get; set; }

        public string address { get; set; }
    }

    public class from
    {
        public string name { get; set; }

        public string address { get; set; }
    }
}
