using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace gnomi.api.models.visitors
{
    public interface iDataClientRequestVisitor
    {
        HttpRequestMessage visit(signUpDataClientRequest signUpRequest);
    }
}