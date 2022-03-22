using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class LevelViewModel :INotifyPropertyChanged
    {
        private Level level;
        private readonly string DEFAULT_FILE = "defaultSaveFile.bin";
        private string currentFile;
        public event PropertyChangedEventHandler PropertyChanged = (s, a) => { };
        public LevelViewModel()
        {
            level = new Level();
        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                openFileDialog.Filter = "Binary files (*.bin)|*.bin";
                using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    using (var binaryReader = new BinaryReader(fileStream))
                    {
                        level = new Level()
                        //own formatting possible
                        {
                            Name = binaryReader.ReadString(),
                            Width = binaryReader.ReadInt32(),
                            Height = binaryReader.ReadInt32()
                        };
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(null));
                    }
                }
            }
        }
        //TODO
        public void NewFile()
        {
            throw new NotImplementedException();
        }
        public void SaveFile()
        {
            currentFile = currentFile == null ? DEFAULT_FILE : currentFile;
                using (var fileStream = new FileStream(currentFile, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream))
                    {
                        //own formatting possible
                        binaryWriter.Write(level.Name);
                        binaryWriter.Write(level.Width);
                        binaryWriter.Write(level.Height);
                    }
                }

        }
        public void SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
                using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.CreateNew))
                {
                    currentFile = saveFileDialog.FileName;
                    using (var binaryWriter = new BinaryWriter(fileStream))
                    {
                        //own formatting possible
                        binaryWriter.Write(level.Name);
                        binaryWriter.Write(level.Width);
                        binaryWriter.Write(level.Height);
                    }
                }
            }
        }
        public void CloseFile()
        {
            currentFile = DEFAULT_FILE;
            new Level() { Name = "defaultFile", Height = 0, Width = 0};
            
        }
    }
}
