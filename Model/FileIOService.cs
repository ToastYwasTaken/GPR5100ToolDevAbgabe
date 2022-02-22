using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using GPR5100ToolDevAbgabe.ViewModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace GPR5100ToolDevAbgabe.Model
{
    public class FileIOService
    {
        private static readonly  string outputPath = System.IO.Path.Combine(Environment.CurrentDirectory, "SaveFiles");
        private Project project;
        public void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }
        public void OpenFile()
        {
            throw new NotImplementedException();
        }
        public void NewFile()
        {
            throw new NotImplementedException();
        }
        public void SaveFile()
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
                string fileName = project.ProjectName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.Create(fileName);
                binaryFormatter.Serialize(fileStream, project);
                fileStream.Close();
                fileStream.Dispose();
        }
        public void SaveFileAs()
        {
            throw new NotImplementedException();
        }
        public void CloseFile()
        {
            throw new NotImplementedException();
        }

    }
}
