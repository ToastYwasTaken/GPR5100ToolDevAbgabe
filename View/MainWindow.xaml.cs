using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using GPR5100ToolDevAbgabe.ViewModel;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : MainWindow.xaml.cs
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
namespace GPR5100ToolDevAbgabe.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = null;

        //private Level level = null;

        public Level Level
        {
            get { return mvm.CurrentLevel; }
            set 
            {
                mvm.CurrentLevel = value;
            }
        }

        ObservableCollection<TileSelectionElement> tileSelectionElements = null;

        public MainWindow()
        {
            InitializeComponent();
            mvm = new MainViewModel();
            DataContext = mvm;
            mvm.SelectedElementChanged += OnIndexChanged;
            //Adding Tiles from current directory into the application
            string[] files = Directory.GetFiles(System.IO.Path.Combine(Environment.CurrentDirectory, "Tiles"), "*.png", SearchOption.TopDirectoryOnly);
            int tileAmount = files.Length;
            tileSelectionElements = new();
            for (int i = 0; i < tileAmount; i++)
            {
                tileSelectionElements.Add(new TileSelectionElement(files[i]));
            }
            TileSelectionListView.ItemsSource = tileSelectionElements;
            Level = new(MainEditorUniformGrid); //erstmaliges Erstellen des Grids
            mvm.GridChanged += OnGridChanged;   //Beim drücken von CreateGrid()
        }

        /// <summary>
        /// Triggers when clicking a tile in the uniform grid
        /// </summary>
        /// <param name="_index"></param>
        public void OnIndexChanged(int _index)
        {
            if(Level != null && tileSelectionElements != null)
            {
                Level.SelectedTileImage = tileSelectionElements[_index].BImage;
            }
        }
        
        /// <summary>
        /// Triggers when clicking "create new Level"
        /// </summary>
        /// <param name="_levelName"></param>
        /// <param name="_levelWidth"></param>
        /// <param name="_levelHeight"></param>
        public void OnGridChanged(string _levelName, int _levelWidth, int _levelHeight)
        {
            Level = new Level(_levelName, _levelWidth, _levelHeight, MainEditorUniformGrid);
        }

    }
}

