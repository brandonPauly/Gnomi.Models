using System.ComponentModel.DataAnnotations;

namespace gnomi.orchestration.requests
{
    public class signUpOrchestrationRequest
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }
    }
}

