namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
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
            get { return param ?? (param = new ResponseParam()); }
            set { param = value; }
        }
    }
}