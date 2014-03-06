namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class Fault
    {
        [XmlElement("value", Namespace = "", IsNullable = false)]
        public FaultValue Value { get; set; }
    }
}