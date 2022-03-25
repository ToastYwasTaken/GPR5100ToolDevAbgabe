using GPR5100ToolDevAbgabe.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GPR5100ToolDevAbgabe.View;
using System.Collections.ObjectModel;
using GPR5100ToolDevAbgabe.Model;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : MainViewModel.cs
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
*	22.03.2022  added properties for selectedElementIndex and selectedElementChanged
******************************************************************************/

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // File specific commands:
        public RelayCommand FileCommand_NewFile { get; }
        public RelayCommand FileCommand_OpenFile { get; }
        public RelayCommand FileCommand_SaveFile { get; }
        public RelayCommand FileCommand_SaveFileAs { get; }
        public RelayCommand FileCommand_CloseFile {get;}
        public RelayCommand EditCommand_Undo { get; }
        public RelayCommand EditCommand_Redo { get; }
        //Program specific commands:
        public RelayCommand ProgramCommand_Help { get; }
        public RelayCommand ProgramCommand_CloseApplication { get; }
        //Editor specific commands
        public RelayCommand CreateGrid { get; }

        private event Action<int> selectedElementChanged;

        public event Action<int> SelectedElementChanged { add => selectedElementChanged += value;  remove => selectedElementChanged -= value;  }

        private int selectedElementIndex;
        public int SelectedElementIndex 
        {
            get => selectedElementIndex;
            set {  RaisePropertyIfChanged(ref selectedElementIndex, value); selectedElementChanged.Invoke(value); } 
        }
        //private Level loadedProject;
        //public Level LoadedProject
        //{
        //    get => loadedProject;
        //    set => RaisePropertyIfChanged(ref loadedProject, value);
        //}
        private int inputHeight;
        public int InputHeight
        {
            get => inputHeight;
            set => RaisePropertyIfChanged(ref inputHeight, value);
        }
        private int inputWidth;
        public int InputWidth
        {
            get => inputWidth;
            set => RaisePropertyIfChanged(ref inputWidth, value);
        }
        private string levelName;
        public string LevelName
        {
            get => levelName;
            set => RaisePropertyIfChanged(ref levelName, value);
        }

        public MainViewModel()
        {
            LevelViewModel levelViewModel = new LevelViewModel();
            FileCommand_NewFile = new RelayCommand(() => levelViewModel.NewFile());
            FileCommand_OpenFile = new RelayCommand(() => levelViewModel.OpenFile());
            FileCommand_SaveFile = new RelayCommand(() => levelViewModel.SaveFile());
            FileCommand_SaveFileAs = new RelayCommand(() => levelViewModel.SaveFileAs());
            FileCommand_CloseFile = new RelayCommand(() => levelViewModel.CloseFile());

            //TODO: HelpWindow, SettingsWindow
            ProgramCommand_Help = new RelayCommand(() => new HelpWindow().ShowDialog());
            ProgramCommand_CloseApplication = new RelayCommand(() => Application.Current.Shutdown());

            //TODO: make Button work
            CreateGrid = new RelayCommand(() => new Level(levelName, inputWidth, inputHeight, null));
        }
        
    }
}
