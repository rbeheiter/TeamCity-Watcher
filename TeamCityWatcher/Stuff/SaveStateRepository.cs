using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TeamCityWatcher
{
    public class SaveStateRepository
    {
        string FileName { get; set; }

        public SaveStateRepository(string fileName)
        {
            FileName = fileName;
        }

        public void WriteToFile(IList<ProjectState> projects)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<ProjectState>));

            System.IO.StreamWriter file = new System.IO.StreamWriter(FileName);
            writer.Serialize(file, projects.ToList());
            file.Close();
        }

        public List<ProjectState> ReadFromFile()
        {
            List<ProjectState> projects = new List<ProjectState>();
            XmlSerializer deserializer = new XmlSerializer(typeof(List<ProjectState>));

            if (File.Exists(FileName))
            { 
                using (TextReader textReader = new StreamReader(FileName))
                {
                    projects = (List<ProjectState>)deserializer.Deserialize(textReader);
                    textReader.Close();
                }
            }

            return projects;
        }
    }
}
