namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.FaultResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class FaultValue
    {
        [XmlArray("struct", Namespace = ""), XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}