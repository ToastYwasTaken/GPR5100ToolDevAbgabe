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

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand RCNewFile { get; }
        public RelayCommand RCOpenFile { get; }
        public RelayCommand RCSaveFile { get; }
        public RelayCommand RCSaveFileAs { get; }

        public RelayCommand RCUndo { get; }
        public RelayCommand RCRedo { get; }
        public RelayCommand RCCloseWindow { get; }
        public RelayCommand RCHelp { get; }

    }
}
