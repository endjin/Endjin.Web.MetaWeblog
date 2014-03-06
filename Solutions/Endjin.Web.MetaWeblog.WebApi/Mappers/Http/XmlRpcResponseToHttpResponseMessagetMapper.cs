﻿namespace Endjin.Web.MetaWeblog.WebApi.Mappers.Http
{
    #region Using Directives

    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;

    using Endjin.Web.MetaWeblog.Contracts.Mappers;
    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion 

    public class XmlRpcResponseToHttpResponseMessagetMapper : IMapper<Response, HttpResponseMessage>
    {
        public HttpResponseMessage MapFrom(Response input)
        {
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new ObjectContent(typeof(Response), input, new XmlMediaTypeFormatter()) };
        }

        public object MapFrom(object input)
        {
            return this.MapFrom((Response)input);
        }
    }
}