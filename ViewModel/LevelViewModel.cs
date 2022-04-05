using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
                        {
                            Name = binaryReader.ReadString(),
                            Width = binaryReader.ReadInt32(),
                            Height = binaryReader.ReadInt32(),
                            GridView = ConvertStringToGridViewElementsList(binaryReader.ReadString())
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
            string gridElementsAsString = ConvertGridElementsToString();
                using (var fileStream = new FileStream(currentFile, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream))
                    {
                        binaryWriter.Write(level.Name);
                        binaryWriter.Write(level.Width);
                        binaryWriter.Write(level.Height);
                        binaryWriter.Write(gridElementsAsString);
                    }
                }

        }

        private string ConvertGridElementsToString()
        {
            string str = "";
            string individualSeperator = ",";   //seperates posX, posY and Image
            string tileGridViewElementSeperator = "/";  //seperates to next element
            for (int i = 0; i < level.GridView.Count; i++)
            {
                string posXstr = level.GridView[i].PosX.ToString();
                string posYstr = level.GridView[i].PosY.ToString();
                string selectedImageStr = level.GridView[i].SelectedImage.ToString();
                str.Concat(posXstr).Concat(individualSeperator).Concat(posYstr).Concat(individualSeperator).Concat(selectedImageStr).Concat(tileGridViewElementSeperator);
            }
            return str;
        }

        private List<TileGridViewElement> ConvertStringToGridViewElementsList(string _stringToConvert)
        {
            string[] tileGridViewElements = _stringToConvert.Split("/");

            for (int i = 0; i < length; i++)
            {

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
