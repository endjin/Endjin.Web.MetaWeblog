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
            @string,
            @int,
            @datetime,
            @double,
            base64,
            array
        }
        
        [XmlChoiceIdentifier("ValueChoice"),
         XmlElement("int", typeof(int), Namespace = ""),
         XmlElement("string", typeof(string), Namespace = ""),
         XmlElement("datetime", typeof(DateTime), Namespace = ""),
         XmlElement("double", typeof(double), Namespace = ""),
         XmlElement("base64", typeof(string), Namespace = ""),
         XmlElement("array", typeof(ArrayList), Namespace = "")]
        public object Value { get; set; }

        [XmlIgnore]
        public virtual ValueType ValueChoice { get; set; }
    }
}