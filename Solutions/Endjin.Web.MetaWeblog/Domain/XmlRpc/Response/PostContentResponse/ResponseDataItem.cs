namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class ResponseDataItem
    {
        private List<MemberValue> value;

        [XmlArray("value", Namespace = "")]
        public List<MemberValue> Value
        {
            get
            {
                return this.value ?? (this.value = new List<MemberValue>());
            }
            set
            {
                this.value = value;
            }
        }
    }
}