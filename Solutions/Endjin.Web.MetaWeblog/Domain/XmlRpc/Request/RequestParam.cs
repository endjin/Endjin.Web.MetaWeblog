namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Request
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

    public class RequestParam
    {
        public RequestParam()
        {
            this.RequestValue = new RequestValue();
        }

        [XmlElement("value", Namespace = "")]
        public RequestValue RequestValue { get; set; }

        //[XmlElement("value", Namespace = "")]
        //public MemberValue MemberValue { get; set; }
    }
}