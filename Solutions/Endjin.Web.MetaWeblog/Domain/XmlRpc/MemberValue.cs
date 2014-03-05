namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System;
    using System.Xml.Serialization;

    #endregion

    public class MemberValue
    {
        public enum ValueType
        {
            [XmlEnum("array")]
            Array,
            [XmlEnum("string")]
            String,
            [XmlEnum("int")]
            Int,
            [XmlEnum("datetime")]
            DateTime,
            [XmlEnum("dateTime.iso8601")]
            Iso8601,
            [XmlEnum("double")]
            Double,
            [XmlEnum("base64")]
            Base64,
            [XmlEnum("boolean")]
            @Boolean
        }

        [XmlChoiceIdentifier("ValueChoice"),
         XmlElement("int", typeof(int), Namespace = ""),
         XmlElement("string", typeof(string), Namespace = ""),
         XmlElement("datetime", typeof(DateTime), Namespace = ""),
         XmlElement("dateTime.iso8601", typeof(string), Namespace = ""),
         XmlElement("double", typeof(double), Namespace = ""),
         XmlElement("base64", typeof(string), Namespace = ""),
         XmlElement("array", typeof(MemberValueArray), Namespace = ""),
         XmlElement("boolean", typeof(int), Namespace = "")]
        public object Value {get; set;}

        [XmlIgnore]
        public virtual ValueType ValueChoice { get; set; }
    }
}