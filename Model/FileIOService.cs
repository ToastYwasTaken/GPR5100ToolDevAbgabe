using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GPR5100ToolDevAbgabe.Model
{
    public class FileIOService : IFileIOService
    {
        public void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }
    }
    public interface IFileIOService
    {
        void OpenFileDialog();
    }
}
