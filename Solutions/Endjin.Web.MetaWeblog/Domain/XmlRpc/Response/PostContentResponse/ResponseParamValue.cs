namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class ResponseParamValue
    {
        private List<Member> member;

        [XmlArray("struct", Namespace = "")]
        [XmlArrayItem("member", Namespace = "")]
        public List<Member> Member 
        {
            get
            {
                return this.member ?? (this.member = new List<Member>());
            }

            set
            {
                this.member = value;
            }
        }
    }
}