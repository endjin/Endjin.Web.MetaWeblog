namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse
{
    #region Using Directives

    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    #endregion 

   // [DataContract(Namespace = "")]
    public class ResponseParam
    {
        [XmlElement("value", Namespace = "")]
        public ResponseData Value { get; set; }
    }
}