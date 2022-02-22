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
        public RelayCommand EditCommand_Undo { get; }
        public RelayCommand EditCommand_Redo { get; }
        //Program specific commands:
        public RelayCommand ProgramCommand_Help { get; }
        public RelayCommand ProgramCommand_CloseApplication { get; }
        public RelayCommand ProgramCommand_OpenSettingsWindow { get; }
        //Editor specific commands
        private int selectedElementIndex;
        public int SelectedElementIndex 
        {
            get => selectedElementIndex;
            set => RaisePropertyIfChanged(ref selectedElementIndex, value);
        }
        private Project loadedProject;

        public Project LoadedProject
        {
            get => loadedProject;
            set => RaisePropertyIfChanged(ref loadedProject, value);
        }


        public MainViewModel()
        {
            ServicesLocator servicesLocator = new ServicesLocator();
            FileCommand_NewFile = new RelayCommand(() => servicesLocator.GetService<FileIOService>().NewFile());
            FileCommand_OpenFile = new RelayCommand(() => servicesLocator.GetService<FileIOService>().OpenFile());
            FileCommand_SaveFile = new RelayCommand(() => servicesLocator.GetService<FileIOService>().SaveFile());
            FileCommand_SaveFileAs = new RelayCommand(() => servicesLocator.GetService<FileIOService>().SaveFileAs());

            EditCommand_Undo = new RelayCommand(() => throw new NotImplementedException());
            EditCommand_Redo = new RelayCommand(() => throw new NotImplementedException());

            ProgramCommand_Help = new RelayCommand(() => throw new NotImplementedException());
            ProgramCommand_CloseApplication = new RelayCommand(() => Application.Current.Shutdown());
            ProgramCommand_OpenSettingsWindow = new RelayCommand(() => new SettingsWindow().ShowDialog());


        }
        
    }
}
