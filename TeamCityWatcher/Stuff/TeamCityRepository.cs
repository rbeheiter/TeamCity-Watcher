using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCitySharp;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCityWatcher
{
    public class TeamCityRepository
    {
        string username;
        string password;
        TeamCityClient client;

        public TeamCityRepository(string hostname, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.client = new TeamCityClient(hostname);
        }

        private void Connect()
        {
            client.Connect(username, password);
        }

        public IList<ProjectState> GetProjects()
        {
            Connect();
            var projects = client.AllProjects()
                                 .Select(p => new ProjectState(p.Name))
                                 .ToList();

            foreach (var project in projects)
            {
                project.Builds = GetBuilds(project.Name);
            }

            return projects;
        }

        public IList<BuildState> GetBuilds(string projectName)
        {
            IList<BuildState> builds = new List<BuildState>();

            Connect();
            
            var buildConfigs = client.BuildConfigsByProjectName(projectName.ToString());
            foreach (var config in buildConfigs)
            {
                var build = client.LastBuildByBuildConfigId(config.Id);
                var buildState = new BuildState()
                {
                    Name = config.Name,
                    BuildId = config.Id,
                    Status = "NOT BUILT"
                };

                if (build != null)
                {
                    buildState.LastBuild = build.Id;
                    buildState.Status = build.Status; 
                }

                builds.Add(buildState);
            }

            return builds;
        }

        private List<Build> GetFailedBuilds(string id)
        {
            var failedBuilds = client.FailedBuildsByBuildConfigId(id);
            var lastSuccessfulBuild = client.LastSuccessfulBuildByBuildConfigId(id);
            var changes = client.ChangeDetailsByBuildConfigId(id);


            if (lastSuccessfulBuild != null)
            {
                failedBuilds = failedBuilds.Where(b => b.StartDate > lastSuccessfulBuild.StartDate).ToList();
            }

            return failedBuilds;
        }

        public IList<string> GetUsersWithChangesSinceLastFailedBuild(string id)
        {
            var failedBuilds = GetFailedBuilds(id);
            var changes = failedBuilds.SelectMany(b => b.Changes.Change, (b, c) => c.Username);
            
            return changes.ToList();
        }
    }
}
