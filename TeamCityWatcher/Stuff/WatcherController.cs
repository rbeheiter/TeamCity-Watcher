using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamCityWatcher
{
    public class WatcherController
    {
        WatcherViewModel viewModel;
        TeamCityRepository tcRepository;
        SaveStateRepository saveRepository;

        public WatcherController(WatcherViewModel vm, TeamCityRepository tcRepo, SaveStateRepository saveRepo)
        {
            viewModel = vm;
            tcRepository = tcRepo;
            saveRepository = saveRepo;
        }

        public void Initialize()
        {
            UpdateBuilds();
            LoadSavedSoundsFromFile();
        }

        private void LoadSavedSoundsFromFile()
        {
            var savedProjects = saveRepository.ReadFromFile();

            foreach (var project in viewModel.Projects)
            {
                var savedProject = savedProjects.FirstOrDefault(p => p.Name.Equals(project.Name));
                if (savedProject != null)
                {
                    project.FailureSound = savedProject.FailureSound;
                    project.StillFailingSound = savedProject.StillFailingSound;
                    project.FixedSound = savedProject.FixedSound;
                }
            }
        }

        public void UpdateBuilds()
        {
            var newProjects = tcRepository.GetProjects();
            var projectsToRemove = new List<ProjectState>();

            foreach (var oldProject in viewModel.Projects)
            {
                var newProject = newProjects.FirstOrDefault(p => p.Name.Equals(oldProject.Name));

                if (newProject != null)
                {
                    CheckProjectState(oldProject, newProject);
                    oldProject.Builds = newProject.Builds;
                }
                else
                {
                    projectsToRemove.Add(oldProject);
                }
            }

            foreach (var project in projectsToRemove)
            {
                viewModel.Projects.Remove(project);
            }

            var projectsToAdd = newProjects.Where(np => viewModel.Projects.All(op => !op.Name.Equals(np.Name)));
            foreach (var project in newProjects)
            {
                if (viewModel.Projects.All(p => !p.Name.Equals(project.Name)))
                {
                    viewModel.Projects.Add(project);
                }
            }
        }

        private void CheckProjectState(ProjectState oldProject, ProjectState newProject)
        {
            foreach (var oldBuildState in oldProject.Builds)
            {
                var newBuildState = newProject.Builds.FirstOrDefault(b => b.Name.Equals(oldBuildState.Name));

                if (newBuildState != null)
                {
                    CheckBuildState(oldProject, oldBuildState, newBuildState);
                }
            }
        }

        private void CheckBuildState(ProjectState project, BuildState oldBuildState, BuildState newBuildState)
        {
            if (oldBuildState.LastBuild != newBuildState.LastBuild)
            {
                if ((newBuildState.Status == "FAILURE" || newBuildState.Status == "ERROR")
                    && oldBuildState.Status == "FAILURE" || oldBuildState.Status == "ERROR")
                {
                    PlaySound(project.StillFailingSound);
                }
                else if (newBuildState.Status == "FAILURE" || newBuildState.Status == "ERROR")
                {
                    PlaySound(project.FailureSound);
                }
                else if (newBuildState.Status == "SUCCESS" && oldBuildState.Status != "SUCCESS")
                {
                    PlaySound(project.FixedSound);
                }
            }
        }

        public void PlaySound(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
        }

        public void SaveState()
        {
            saveRepository.WriteToFile(viewModel.Projects);
        }
    }
}
