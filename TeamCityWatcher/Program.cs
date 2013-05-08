using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCityWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = ConfigurationManager.AppSettings;

            var saveRepositroy = new SaveStateRepository(config["SaveFile"]);
            var tcRepository = new TeamCityRepository(config["TeamCityHost"], config["TeamCityUser"], config["TeamCityPassword"]);
            var viewModel = new WatcherViewModel(Convert.ToInt32(config["UpdateInterval"]));
            var controller = new WatcherController(viewModel, tcRepository, saveRepositroy);
            var view = new WatcherView(viewModel, controller);
            var updater = new BackgroundUpdater(view, viewModel, controller);
            updater.Start();

            Application.Run(view);
        }
    }
}
