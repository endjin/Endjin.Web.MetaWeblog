using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives



    #endregion

    public class Fault
    {
        [XmlElement("value", Namespace = "", IsNullable = true)]
        public FaultValue Value { get; set; }
    }
}