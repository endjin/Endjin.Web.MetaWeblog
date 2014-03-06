namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class ResponseData
    {
        public ResponseData()
        {
            this.Data = new List<ResponseDataItem>();
        }

        [XmlArray("array", Namespace = ""), XmlArrayItem("data", Namespace = "")]
        public List<ResponseDataItem> Data { get; set; }
    }
}