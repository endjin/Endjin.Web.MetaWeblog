namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    #endregion 

    public class RequestValue
    {
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
        public virtual MemberValue.ValueType ValueChoice { get; set; }

        [XmlArray("struct", Namespace = "")]
        [XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}
