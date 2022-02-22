using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class Project : ViewModelBase
    {        
        private string projectName;
        public string ProjectName
        {
            get => projectName;
            set => RaisePropertyIfChanged(ref projectName, value);
        }
        public Project(string _projectName = default)
        {
            projectName = _projectName;
        }

    }
}
