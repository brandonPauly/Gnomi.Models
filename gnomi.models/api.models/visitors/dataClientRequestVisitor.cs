using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace gnomi.api.models.visitors
{
    public class dataClientRequestVisitor : iDataClientRequestVisitor
    {
        public HttpRequestMessage visit(signUpDataClientRequest dataClientRequest)
        {
            return new HttpRequestMessage();
        }
    }
}
