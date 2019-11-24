

namespace gnomi.common.models.smtp
{
    public class mailMessageData
    {
        public string toEmailAddress { get; set; }

        public string fromEmailAddress { get; set; }

        public string fromName { get; set; }

        public string body { get; set; }

        public string subject { get; set; }
    }
}
