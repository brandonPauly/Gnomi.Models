using System.Collections.Generic;

namespace gnomi.common.models.general
{
    public class passwordValidation
    {
        public passwordValidation()
        {
            validationStatus = new List<string>();
        }

        public bool isValid { get; set; }

        public List<string> validationStatus { get; set; }
    }
}
