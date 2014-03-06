namespace Endjin.Web.MetaWeblog.WebApi.Configuration
{
    #region Using Directives

    using System;
    using System.Net.Http.Formatting;
    using System.Web.Http.Controllers;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    #endregion 

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class XmlRpcConfigAttribute : Attribute, IControllerConfiguration
    {
        public void Initialize(HttpControllerSettings controllerSettings, HttpControllerDescriptor controllerDescriptor)
        {
            controllerSettings.Formatters.Clear();

            var xmlFormatter = new XmlMediaTypeFormatter { UseXmlSerializer = true };
            xmlFormatter.SetSerializer<RequestTop>(new XmlSerializer(typeof(RequestTop)));

            xmlFormatter.SetSerializer<Domain.XmlRpc.Response.FaultResponse.Response>(new XmlSerializer(typeof(Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse.Response)));
            xmlFormatter.SetSerializer<Domain.XmlRpc.Response.ConfirmationResponse.Response>(new XmlSerializer(typeof(Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse.Response)));
            xmlFormatter.SetSerializer<Domain.XmlRpc.Response.MetaDataResponse.Response>(new XmlSerializer(typeof(Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse.Response)));
            xmlFormatter.SetSerializer<Domain.XmlRpc.Response.PostContentResponse.Response>(new XmlSerializer(typeof(Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse.Response)));

            controllerSettings.Formatters.Add(xmlFormatter);
        }
    }
}