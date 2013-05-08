using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamCitySharp;
using TeamCitySharp.Locators;

namespace TeamCityWatcher
{
    public partial class WatcherView : Form
    {
        WatcherViewModel viewModel;
        WatcherController controller;

        public WatcherView(WatcherViewModel viewModel, WatcherController controller)
        {
            this.viewModel = viewModel;
            this.controller = controller;

            InitializeComponent();
            controller.Initialize();
            UpdateBuildGridView();

            projectGridView.DataSource = viewModel.Projects;
            projectGridView.Columns["Builds"].Visible = false;

            UpdateIntervalBox.Text = string.Format("Update Interval: {0}s", viewModel.UpdateInterval / 1000.0);
        }

        private void ProjectClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBuildGridView();
        }

        private void UpdateBuildGridView()
        {
            var selectedProject = GetSelectedProjects().FirstOrDefault();

            if (selectedProject != null)
            {
                buildGridView.DataSource = selectedProject.Builds;
            }
        }

        private void pickFailedSoundButton_Click(object sender, EventArgs e)
        {
            string fileName = GetSoundFileDialog();
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var project in GetSelectedProjects())
                {
                    project.FailureSound = fileName;
                }
            }
        
            projectGridView.Refresh();
            controller.SaveState();
        }

        private void pickStillFailingSoundButton_Click(object sender, EventArgs e)
        {
            string fileName = GetSoundFileDialog();
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var project in GetSelectedProjects())
                {
                    project.StillFailingSound = fileName;
                }
            }

            projectGridView.Refresh();
            controller.SaveState();
        }

        private void pickFixedSoundButton_Click(object sender, EventArgs e)
        {
            string fileName = GetSoundFileDialog();
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var project in GetSelectedProjects())
                {
                    project.FixedSound = fileName;
                }
            }

            projectGridView.Refresh();
            controller.SaveState();
        }

        private void playFailedSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                controller.PlaySound(project.FailureSound);
            }
        }

        private void playStillFailingSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                controller.PlaySound(project.StillFailingSound ?? project.FailureSound);
            }
        }

        private void playFixedSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                controller.PlaySound(project.FixedSound);
            }
        }

        private void clearFailureSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                project.FailureSound = null;
            }

            projectGridView.Refresh();
            controller.SaveState();
        }

        private void clearStillFailingSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                project.StillFailingSound = null;
            }

            projectGridView.Refresh();
            controller.SaveState();
        }

        private void clearFixedSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var project in GetSelectedProjects())
            {
                project.FixedSound = null;
            }

            projectGridView.Refresh();
            controller.SaveState();
        }

        private string GetSoundFileDialog()
        {
            string fileName = string.Empty;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }

            return fileName;
        }

        private IList<ProjectState> GetSelectedProjects()
        {
            List<ProjectState> selected = new List<ProjectState>();
            for (int i = 0; i < projectGridView.Rows.GetRowCount(DataGridViewElementStates.Selected); i++)
            {
                selected.Add(viewModel.Projects[projectGridView.SelectedRows[i].Index]);
            }
            return selected;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            StartUpdating();
            controller.UpdateBuilds();
            FinishUpdating();
        }

        public void StartUpdating()
        {
            this.Invoke((MethodInvoker)delegate
            {
                updateButton.Enabled = false;
                LoadingLabel.Show();
            });
        }

        public void FinishUpdating()
        {
            this.Invoke((MethodInvoker)delegate
            {
                updateButton.Enabled = true;
                LoadingLabel.Hide();
                UpdateBuildGridView();
            });
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            controller.SaveState();
        }
    }
}
