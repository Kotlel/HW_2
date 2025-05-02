using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_homework2.Classes
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public int Capacity { get; set; }
        public List<string> Facilities { get; set; }
        public int EstablishedYear { get; set; }
    }
}
