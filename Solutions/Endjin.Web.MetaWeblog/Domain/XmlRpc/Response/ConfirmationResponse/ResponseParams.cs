namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.ConfirmationResponse
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion 

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