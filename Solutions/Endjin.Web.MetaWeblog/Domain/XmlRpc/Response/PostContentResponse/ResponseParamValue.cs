namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class ResponseParamValue
    {
        public ResponseParamValue()
        {
            this.Member = new List<Member>();
        }

        [XmlArray("struct", Namespace = ""), XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}