using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinForms_homework2.Classes
{
    public class RootObject
    {
        public RootData root { get; set; }
    }

    public class RootData
    {
        public List<Camp> camps { get; set; }
        public List<Refugee> refugees { get; set; }
        public List<Employee> staff { get; set; }
    }
}
