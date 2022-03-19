using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    [Serializable]
    public class Level
    {        
        private string name;
        public string Name { get; set; }
        private int width;
        public int Width { get; set; }
        private int height;
        public int Height { get; set; }
        public Level()
        {
            
        }
        public Level(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

    }
}
