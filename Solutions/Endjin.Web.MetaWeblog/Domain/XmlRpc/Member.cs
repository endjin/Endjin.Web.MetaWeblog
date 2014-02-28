using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class Member
    {
        [XmlElement("name", Namespace = "")]
        public string Name { get; set; }

        [XmlElement("value", Namespace = "")]
        public MemberValue Value { get; set; }
    }
}