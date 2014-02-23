namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
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
    }
}