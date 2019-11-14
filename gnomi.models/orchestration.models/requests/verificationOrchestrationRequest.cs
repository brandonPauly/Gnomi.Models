using System.ComponentModel.DataAnnotations;

namespace gnomi.models.orchestration.models.requests
{
    public class verificationOrchestrationRequest
    {
        [StringLength(96)]
        public string verificationCode { get; set; }
    }
}
