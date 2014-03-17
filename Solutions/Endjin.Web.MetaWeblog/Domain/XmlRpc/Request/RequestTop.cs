namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc.Request;

    #endregion

    [XmlRoot("methodCall", Namespace = "")]
    public class RequestTop
    {
        [XmlElement("methodName", Namespace = "")]
        public string Method { get; set; }

        [XmlArray("params", Namespace = "")]
        [XmlArrayItem("param", Namespace = "")]
        public List<RequestParam> Params { get; set; }

        //TODO
        protected internal string ValueAsString(int position, string memberName)
        {
            return
                this.Params.ElementAt(position)
                    .RequestValue.Member.FirstOrDefault(member => member.Name.ToString() == memberName)
                    .Value.Value.ToString();
        }

        protected internal string[] ValueAsArray(int position, string memberName)
        {
            return
                ((MemberValueArray)this.Params.ElementAt(position)
                    .RequestValue.Member.FirstOrDefault(
                        member => member.Name.ToString(CultureInfo.InvariantCulture) == memberName)
                    .Value.Value).Value.Select(memberValue => memberValue.Value.ToString()).ToArray();
        }
    }
}