using System.Xml.Serialization;
using Endjin.Core.Installers;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class RequestParam
    {
        public RequestParam()
        {
            this.RequestValue = new RequestValue();
        }

        [XmlElement("value", Namespace = "")]
        public RequestValue RequestValue { get; set; }

        //[XmlElement("value", Namespace = "")]
        //public MemberValue MemberValue { get; set; }
    }
}