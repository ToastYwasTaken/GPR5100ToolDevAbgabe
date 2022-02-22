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
    public class FileIOService : IFileIOService
    {
        private static readonly  string outputPath = System.IO.Path.Combine(Environment.CurrentDirectory, "SaveFiles");
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() ?? false)
            {
                string fileName = saveFileDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.Create(fileName);
                binaryFormatter.Serialize(fileStream, levelEditorData);
                fileStream.Close();
                fileStream.Dispose();

            }

            throw new NotImplementedException();
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
    public interface IFileIOService
    {
        void OpenFile();
        void NewFile();
        void SaveFile();
        void SaveFileAs();
        void CloseFile();
    }
}
