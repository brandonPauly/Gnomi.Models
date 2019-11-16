using System;

namespace gnomi.dataService.entities
{
    public class verification<t> : iEntity<t>
    {
        public long humanId { get; set; }

        public string verificationCode { get; set; }

        public DateTime initiationDate { get; set; }
    }
}
