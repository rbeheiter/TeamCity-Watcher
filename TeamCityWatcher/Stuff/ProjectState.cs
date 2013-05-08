using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TeamCityWatcher
{
    [Serializable]
    public class ProjectState
    {
        public string Name { get; set; }
        public string FailureSound { get; set; }
        public string StillFailingSound { get; set; }
        public string FixedSound { get; set; }

        [XmlIgnore]
        public IList<BuildState> Builds { get; set; }

        public ProjectState()
        {
            Builds = new List<BuildState>();
        }

        public ProjectState(string name)
            : this()
        {
            Name = name;
        }
    }
}
