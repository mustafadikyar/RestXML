using System;
using System.Xml.Serialization;

namespace RestXML.Models
{
    [Serializable]
    [XmlRoot("response")]
    public class PersonResponseModel
    {
        [XmlElement("personId")]
        public int PersonId { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("surname")]
        public string Surname { get; set; }
    }
}
