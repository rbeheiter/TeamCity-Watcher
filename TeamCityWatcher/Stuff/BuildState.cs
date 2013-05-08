using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityWatcher
{
    public class BuildState
    {
        public string Name { get; set; }
        public string LastBuild { get; set; }
        public string Status { get; set; }
        public string BuildId;

    }
}
