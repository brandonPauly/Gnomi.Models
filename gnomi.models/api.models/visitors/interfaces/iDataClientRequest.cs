using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace gnomi.api.models.visitors
{
    interface iDataClientRequest
    {
        HttpRequestMessage accept(iDataClientRequestVisitor visitor);
    }
}