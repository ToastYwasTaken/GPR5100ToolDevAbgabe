using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using GPR5100ToolDevAbgabe.Model;
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

//Save all tiles
namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class LevelViewModel :INotifyPropertyChanged
    {
        private readonly string DEFAULT_FILE = "defaultSaveFile.bin";
        private string currentFile;
        public event PropertyChangedEventHandler PropertyChanged = (s, a) => { };
        public LevelViewModel()
        {

        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (openFileDialog.ShowDialog() == true)
            {
                using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    using (var binaryReader = new BinaryReader(fileStream))
                    {
                        Level level = new Level(null)
                        {
                            Name = binaryReader.ReadString(),
                            Width = binaryReader.ReadInt32(),
                            Height = binaryReader.ReadInt32(),
                            GridView = BitmapConverter.ConvertStringToGridViewElementsList(binaryReader.ReadString())
                        };
                        //PropertyChanged.Invoke(this, new PropertyChangedEventArgs(null));
                    }
                }
            }
        }
        //TODO
        public void NewFile()
        {
            throw new NotImplementedException();
        }
        public void SaveFile(Level _currentLevel)
        {
            currentFile = currentFile == null ? DEFAULT_FILE : currentFile;
                using (var fileStream = new FileStream(currentFile, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream))
                    {
                        binaryWriter.Write(_currentLevel.Name);
                        binaryWriter.Write(_currentLevel.Width);
                        binaryWriter.Write(_currentLevel.Height);
                        binaryWriter.Write(BitmapConverter.ConvertGridElementsToString(_currentLevel.GridView));
                    }
                }
        }

        public void SaveFileAs(Level _currentLevel)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (saveFileDialog.ShowDialog() == true)
            {
                using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    currentFile = saveFileDialog.FileName;
                    using (var binaryWriter = new BinaryWriter(fileStream))
                    {
                        binaryWriter.Write(_currentLevel.Name);
                        binaryWriter.Write(_currentLevel.Width);
                        binaryWriter.Write(_currentLevel.Height);
                        binaryWriter.Write(BitmapConverter.ConvertGridElementsToString(_currentLevel.GridView));
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
