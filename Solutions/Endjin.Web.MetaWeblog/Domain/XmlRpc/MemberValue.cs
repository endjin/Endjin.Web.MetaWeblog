using System.ComponentModel;
using System.Reflection;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System;
    using System.Collections;
    using System.Xml.Serialization;

    #endregion

    public class MemberValue
    {
        public enum ValueType
        {
            [XmlEnumAttribute("array")]
            Array,
            [XmlEnumAttribute("string")]
            String,
            [XmlEnumAttribute("int")]
            Int,
            [XmlEnumAttribute("datetime")]
            DateTime,
            [XmlEnumAttribute("dateTime.iso8601")]
            Iso8601,
            [XmlEnumAttribute("double")]
            Double,
            [XmlEnumAttribute("base64")]
            Base64
        }

        [XmlChoiceIdentifier("ValueChoice"),
         XmlElement("int", typeof(int), Namespace = ""),
         XmlElement("string", typeof(string), Namespace = ""),
         XmlElement("datetime", typeof(DateTime), Namespace = ""),
         XmlElement("dateTime.iso8601", typeof(string), Namespace = ""),
         XmlElement("double", typeof(double), Namespace = ""),
         XmlElement("base64", typeof(string), Namespace = ""),
         XmlElement("array", typeof(MemberValueArray), Namespace = "")]
        public object Value {get; set;}

        [XmlIgnore]
        public virtual ValueType ValueChoice { get; set; }
    }
}