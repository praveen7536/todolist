using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolistwebapp.Requests
{
    public class Addtask
    {
        public string Todo { get; set; }
        public bool Iscomplete { get; set; }
    }
}
