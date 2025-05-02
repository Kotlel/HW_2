using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinForms_homework2.Classes
{
    public class PersonalInfo
    {
        [XmlElement("BirthDate")] public string BirthDate { get; set; }
        [XmlElement("Citizenship")] public string Citizenship { get; set; }
    }
}
