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

            var xmlFormatter = new XmlMediaTypeFormatter();
            xmlFormatter.UseXmlSerializer = true;
            xmlFormatter.SetSerializer<Request>(new XmlSerializer(typeof(Request)));
            xmlFormatter.SetSerializer<Response>(new XmlSerializer(typeof(Response)));

            controllerSettings.Formatters.Add(xmlFormatter);
        }
    }
}