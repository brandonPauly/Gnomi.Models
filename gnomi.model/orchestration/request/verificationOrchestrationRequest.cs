using System.ComponentModel.DataAnnotations;

namespace gnomi.model.orchestration.request
{
    public class verificationOrchestrationRequest
    {
        [StringLength(96)]
        public string verificationCode { get; set; }
    }
}
