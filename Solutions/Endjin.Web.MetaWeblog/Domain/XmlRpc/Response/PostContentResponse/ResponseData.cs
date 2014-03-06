namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class ResponseData
    {
        private List<ResponseDataItem> data;

        [XmlArray("array", Namespace = ""), XmlArrayItem("data", Namespace = "")]
        public List<ResponseDataItem> Data
        {
            get
            {
                return this.data ?? (this.Data = new List<ResponseDataItem>());
            }

            set
            {
                this.data = value;
            }
        }
    }
}
