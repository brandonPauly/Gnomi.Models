using gnomi.api.models.visitors;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace gnomi.api.models
{
    public class signUpDataClientRequest : iDataClientRequest
    {
        [StringLength(254)]
        public string email { get; set; }

        [StringLength(43)]
        public string password { get; set; }

        public HttpRequestMessage accept(iDataClientRequestVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
