namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    #endregion 

   // [DataContract(Namespace = "")]
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
