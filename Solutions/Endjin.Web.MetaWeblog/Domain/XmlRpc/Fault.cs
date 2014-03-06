namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class Fault
    {
        [XmlElement("value", Namespace = "", IsNullable = true)]
        public FaultValue Value { get; set; }
    }
}