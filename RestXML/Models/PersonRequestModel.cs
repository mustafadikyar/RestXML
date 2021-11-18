using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace RestXML.Models
{
    [Serializable]
    [XmlRoot("PersonRequestModel")] //400 error
    public class PersonRequestModel
    {
        [XmlElement("cultureId")]
        [DefaultValue(90)]
        public short CultureId { get; set; }

        [XmlElement("currentUICulture")]
        public string CurrentUICulture { get; set; }
    }
}
