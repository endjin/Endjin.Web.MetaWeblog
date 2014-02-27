using System.Collections;
using System.Xml;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Xml.Serialization;
    using System.Collections.Generic;

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
