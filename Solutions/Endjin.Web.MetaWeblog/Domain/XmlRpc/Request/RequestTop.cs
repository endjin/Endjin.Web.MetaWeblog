namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System;
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

        protected internal string ContentValueAsString(int position, string memberName)
        {
            var result = this.Params.ElementAt(position)
                .RequestValue.Member.FirstOrDefault(member => member.Name.ToString(CultureInfo.InvariantCulture) == memberName);
            if (
                result != null)
            {
                return
                    result
                        .Value.Value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        protected internal string[] ContentValueAsArray(int position, string memberName)
        {
            var result = this.Params.ElementAt(position)
                .RequestValue.Member.FirstOrDefault(
                    member => member.Name.ToString(CultureInfo.InvariantCulture) == memberName);
            if (
                result != null)
            {
                return
                    ((MemberValueArray)result
                                           .Value.Value).Value.Select(memberValue => memberValue.Value.ToString()).ToArray();
            }
            else
            {
                return new string[0];
            }
            
        }
    }
}