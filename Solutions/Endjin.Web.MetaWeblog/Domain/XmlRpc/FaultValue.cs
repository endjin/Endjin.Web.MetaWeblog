using System.Collections.Generic;
using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class FaultValue
    {
        [XmlArray("struct", Namespace = ""), XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}