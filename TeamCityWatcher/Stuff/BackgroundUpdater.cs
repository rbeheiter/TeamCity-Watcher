using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamCityWatcher
{
    public class BackgroundUpdater
    {
        public delegate void UpdateStartEvent();
        public delegate void UpdateDoneEvent();
        public delegate void UpdateEvent();

        WatcherViewModel viewModel;
        BackgroundWorker worker;

        UpdateStartEvent UpdateStarted;
        UpdateDoneEvent UpdateCompleted;
        UpdateEvent Update;

        public BackgroundUpdater(WatcherView view, WatcherViewModel viewModel, WatcherController controller)
        {
            this.viewModel = viewModel;

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;

            UpdateStarted += view.StartUpdating;
            UpdateCompleted += view.FinishUpdating;
            Update += controller.UpdateBuilds;
        }

        public void Start()
        {
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(viewModel.UpdateInterval);

                UpdateStarted();
                Update();
                UpdateCompleted();
            }
        }
    }
}
