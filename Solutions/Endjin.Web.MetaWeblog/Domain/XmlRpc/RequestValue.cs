using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Endjin.Web.MetaWeblog.Domain.XmlRpc;

namespace Endjin.Web.MetaWeblog.Domain.XmlRpc
{
    #region Using Directives

    

    #endregion 

    public class RequestValue
    {
        //public enum ValueType
        //{
        //    [XmlEnum("array")]
        //    Array,
        //    [XmlEnum("string")]
        //    String,
        //    [XmlEnum("int")]
        //    Int,
        //    [XmlEnum("datetime")]
        //    DateTime,
        //    [XmlEnum("dateTime.iso8601")]
        //    Iso8601,
        //    [XmlEnum("double")]
        //    Double,
        //    [XmlEnum("base64")]
        //    Base64
        //}

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
        public virtual MemberValue.ValueType ValueChoice { get; set; }

        //Replaced with section above, as other elements than string may be required. 
        //[XmlElement("string", Namespace = "")]
        //public string String { get; set; }

        [XmlArray("struct", Namespace = "")]
        [XmlArrayItem("member", Namespace = "")]
        public List<Member> Member { get; set; }
    }
}

        