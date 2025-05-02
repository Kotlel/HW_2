using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinForms_homework2.Classes
{
    public class Refugee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public Document Documents { get; set; }
        public HealthInfo HealthInfo { get; set; }
    }
}
