using System.Xml.Serialization;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class ResponseParams
    {
        public ResponseParams()
        {
            this.Param = new ResponseParam();
        }

        [XmlElement("param", Namespace = "")]
        public ResponseParam Param { get; set; }
    }
}