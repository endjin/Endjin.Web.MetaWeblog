namespace Endjin.Web.MetaWeblog.Domain.XmlRpc.Response.PostContentResponse
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class Response 
    {
        private List<ResponseParams> responseParams;

        [XmlElement("params", Namespace = "")]
        public List<ResponseParams> Params
        {
            get { return this.responseParams ?? (this.Params = new List<ResponseParams>()); }
            set { this.responseParams = value; }
        }
    }

}