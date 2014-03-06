namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

    public class ResponseParam
    {
        [XmlElement("value", Namespace = "")]
        public ResponseData Value { get; set; }

    }
}