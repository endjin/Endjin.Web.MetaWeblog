namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    [XmlRoot("methodResponse", Namespace = "")]
    public class Response
    {
        public Response()
        {
            this.Params = new List<ResponseParams>();
        }

        [XmlElement("fault", Namespace = "", IsNullable = true)]
        public Fault Fault { get; set; }

        [XmlElement("params", Namespace = "")]
        public List<ResponseParams> Params { get; set; }
    }

}