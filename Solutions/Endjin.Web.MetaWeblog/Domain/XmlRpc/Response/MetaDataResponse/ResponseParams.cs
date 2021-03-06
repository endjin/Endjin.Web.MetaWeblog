namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.MetaDataResponse
{
    #region Using Directives

    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    #endregion 

    [XmlRoot("ResponseParams", Namespace = "")]
    public class ResponseParams
    {
        private ResponseParam param;

        [XmlElement("param", Namespace = "")]
        public ResponseParam Param
        {
            get { return this.param ?? (this.param = new ResponseParam()); }
            set { this.param = value; }
        }
    }
}