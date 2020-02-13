using System.ComponentModel.DataAnnotations;

namespace gnomi.model.orchestration.request
{
    public class signUpOrchestrationRequest
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }
    }
}

