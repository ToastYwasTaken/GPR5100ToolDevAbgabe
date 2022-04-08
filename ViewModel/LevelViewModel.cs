using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;
using GPR5100ToolDevAbgabe.Model;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
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
    public class LevelViewModel : INotifyPropertyChanged
    {
        private readonly string DEFAULT_FILE = "defaultSaveFile.bin";
        private string currentFile;
        public event PropertyChangedEventHandler PropertyChanged = (s, a) => { };

        public LevelViewModel()
        {

        }

        public LevelData OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (openFileDialog.ShowDialog() == true)
            {
                using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    try
                    {
                        currentFile = openFileDialog.FileName;
                        BinaryFormatter binaryFormatter = new();
                        return binaryFormatter.Deserialize(fileStream) as LevelData;
                    }
                    catch (Exception e)
                    {
                        throw new SerializationException(e.ToString());
                    }
                }
            }
            return null;
        }
        //TODO
        public void NewFile()
        {
            throw new NotImplementedException();
        }
        public void SaveFile(LevelData _currentLevelData)
        {
            if (_currentLevelData == null)
            {
                return;
            }
            currentFile = currentFile == null ? DEFAULT_FILE : currentFile;
            try
            {
                using (var fileStream = new FileStream(currentFile, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new();
                    binaryFormatter.Serialize(fileStream, _currentLevelData);
                }
            }
            catch (Exception e)
            {
                throw new SerializationException(e.ToString());
            }
        }

        public void SaveFileAs(LevelData _currentLevelData)
        {
            if (_currentLevelData == null)
            {
                return;
            }
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        currentFile = saveFileDialog.FileName;
                        BinaryFormatter binaryFormatter = new();
                        binaryFormatter.Serialize(fileStream, _currentLevelData);
                    }
                }
                catch (Exception e)
                {
                    throw new SerializationException(e.ToString());
                }

            }
        }

        public void CloseFile()
        {
            currentFile = DEFAULT_FILE;
            //new Level(null) { Name = "defaultFile", Height = 0, Width = 0 };
        }


    }

    [Serializable]
    public class LevelData
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }       
        private int width;
        public int Width
        {
            get => width;
            set => width = value;
        }

        private TileGridViewElement[,] elements;

        public TileGridViewElement [,] Elements
        {
            get => elements;
            set => elements = value;
        }

    }

}
