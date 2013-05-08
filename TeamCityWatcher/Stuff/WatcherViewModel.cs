using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCityWatcher
{
    public class WatcherViewModel
    {
        public BindingList<ProjectState> Projects { get; set; }
        public int UpdateInterval { get; set; }

        public WatcherViewModel(int updateInterval)
        {
            Projects = new BindingList<ProjectState>();
            UpdateInterval = updateInterval;
        }
    }
}
