using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

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

        private event Action<BitmapImage> selectedElementChanged;

        public event Action<BitmapImage> SelectedElementChanged
        {
            add => selectedElementChanged += value;
            remove => selectedElementChanged -= value;
        }

        private BitmapImage selectedTileImage;
        public BitmapImage SelectedTileImage
        {
            get => selectedTileImage; 
            set 
            { 
                selectedTileImage = value;
                selectedElementChanged.Invoke(value);
                if (gridView.Count > 0) 
                { 

                } 
            }
        }

        private List<TileGridViewElement> gridView = new List<TileGridViewElement>();

        private UniformGrid uniformGrid;

        public Level(UniformGrid _uniformGrid)
        {
            uniformGrid = _uniformGrid;
            name = "defaultLevel";
            width = 10;
            height = 10;
            if(uniformGrid != null)
            {
                InitGrid();
            }
        }

        public Level(string _name, int _width, int _height, UniformGrid _uniformGrid)
        {
            uniformGrid = _uniformGrid;
            name = _name;
            width = _width;
            height = _height;
            if (uniformGrid != null)
            {
                InitGrid();
            }
        }

        public void InitGrid()
        {
            TileGridViewElement tile = null;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tile = new TileGridViewElement();
                    tile.PosX = i;
                    tile.PosY = j;
                    tile.BImage = null;
                    SelectedElementChanged += tile.OnPassImage;
                    uniformGrid.Children.Add(tile.Button);
                    gridView.Add(tile);
                }
            }
        }



    }

}
