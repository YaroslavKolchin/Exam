using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    public class Project
    {
        public Project() { }
        public Project(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
    }
}
