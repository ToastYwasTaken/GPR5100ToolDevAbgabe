using System;
using System.Collections.Generic;
using System.Text;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class ViewModelLocator
    {
        private static Lazy<MainViewModel> mainViewModel = new(() => new());

        public MainViewModel VMMain => mainViewModel.Value;

        public SettingsViewModel VMSettings => new();
    }
}
