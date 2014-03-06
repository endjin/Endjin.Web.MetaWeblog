namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Request
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

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
