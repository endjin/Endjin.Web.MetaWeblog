namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion

    public class RequestParamValue
    {
        public RequestParamValue()
        {
            this.Member = new List<Member>();
        }

        [XmlArray("struct", Namespace = ""), XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}