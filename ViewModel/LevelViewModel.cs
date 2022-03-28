using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : LevelViewModel.cs
* Date   : 16.02.2022
* Author : Franz Mörike (FM)
*
* These coded instructions, statements, and computer programs contain
* proprietary information of the author and are protected by Federal
* copyright law. They may not be disclosed to third parties or copied
* or duplicated in any form, in whole or in part, without the prior
* written consent of the author.
* 
* Disclaimer: The code bases on lectures from GPR5100ToolDevelopement. 
* Unless claimed the rights for the code base go to the lecturer.
*
* ChangeLog
* ----------------------------
*	16.02.2022  created
******************************************************************************/

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
            level = new Level(null);
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
                        level = new Level(null)
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
            new Level(null) { Name = "defaultFile", Height = 0, Width = 0};
            
        }
    }
}
