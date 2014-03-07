namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class ResponseStruct
    {
        private List<Member> member;

        [XmlArray("struct", Namespace = ""), XmlArrayItem("member", Namespace = "")]
        public List<Member> Member
        {
            get
            {
                return this.member ?? (this.Member = new List<Member>());
            }

            set
            {
                this.member = value;
            }
        }
    }
}