namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class Response
    {
        private List<ResponseParams> responseParams;

        [XmlElement("fault", Namespace = "", IsNullable = true)]
        public Fault Fault { get; set; }

        [XmlElement("params", Namespace = "")]
        public List<ResponseParams> Params
        {
            get { return responseParams ?? (Params = new List<ResponseParams>()); }
            set { responseParams = value; }
        }
    }
}