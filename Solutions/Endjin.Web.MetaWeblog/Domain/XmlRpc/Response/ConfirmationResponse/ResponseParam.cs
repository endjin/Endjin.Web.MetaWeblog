namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

    public class ResponseParam
    {
        [XmlElement("value", Namespace = "")]
        public MemberValue Value { get; set; }

    }
}