using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Remote
{
    public class privatemethode
    {
        private string name { get; set; }

        public string Name
        {
            get { return name; }
            set { name=value; }

        }

        public privatemethode(string name)
        {
            Name = name;
        }
    }
}
