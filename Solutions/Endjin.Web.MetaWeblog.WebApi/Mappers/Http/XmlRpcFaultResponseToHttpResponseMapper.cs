﻿namespace Endjin.Web.MetaWeblog.WebApi.Mappers.Http
{
    #region using directives

    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse;

    #endregion

    public class XmlRpcFaultResponseToHttpResponseMapper : IMapper<Response, HttpResponseMessage>
    {
        public HttpResponseMessage MapFrom(Response input)
        {
            var xmlFormatter = new XmlMediaTypeFormatter { UseXmlSerializer = true };
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new ObjectContent(typeof(Response), input, xmlFormatter) };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Response)input);
        }
    }
}