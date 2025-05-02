using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_homework2.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int ExperienceYears { get; set; }
        public List<string> Skills { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
