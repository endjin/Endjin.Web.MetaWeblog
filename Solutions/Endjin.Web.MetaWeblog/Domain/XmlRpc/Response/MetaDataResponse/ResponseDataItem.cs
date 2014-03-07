namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse
{
    #region Using Directives

    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    #endregion 

    //[DataContract(Namespace = "")]
    public class ResponseDataItem
    {
        [XmlElement("value", Namespace = "")]
        public ResponseParamValue Value { get; set; }
    }
}