using System.Collections.Generic;
using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion

    public class MemberValueArray
    {
        public MemberValueArray()
        {
            this.Value = new List<MemberValue>();
        }

        [XmlArray("data", Namespace = ""), XmlArrayItem("value", Namespace = "")]
        public List<MemberValue> Value { get; set; }
    }
}
