using System.Collections.Generic;

namespace gnomi.model.common.middleware
{
    public class apiError
    {
        public int status { get; set; }

        public List<string> messages { get; set; }
    }
}
