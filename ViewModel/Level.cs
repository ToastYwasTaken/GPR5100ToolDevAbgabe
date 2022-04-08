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
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : Level.cs
* Date   : 25.03.2022
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
*	01.03.2022  created
*	25.03.2022  updated ctor
*	06.04.2022  changed GridView structure to array
*	
******************************************************************************/
namespace GPR5100ToolDevAbgabe.ViewModel
{
    [Serializable]
    public class Level
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private int width;
        public int Width { get => width; set => width = value; }
        private int height;
        public int Height { get => height; set => height = value; }

        private TileGridViewElement[,] gridView = null;

        public TileGridViewElement[,] GridView
        {
            get => gridView;
            set => gridView = value;
        }

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
            }
        }

        private UniformGrid uniformGrid;

        public Level(UniformGrid _uniformGrid)
        {
            uniformGrid = _uniformGrid;
            name = "defaultLevel";
            width = 10;
            height = 10;
            if(uniformGrid != null)
            {
                uniformGrid.Children.Clear();
                gridView = null;
                InitGrid();
            }
        }

        public Level(string _name, int _width, int _height, UniformGrid _uniformGrid)
        {
            uniformGrid = _uniformGrid;
            if (_height < 0 || _width < 0)
            {
                return;
            }
            name = _name;
            width = _width;
            height = _height;
            if (uniformGrid != null)
            {
                uniformGrid.Children.Clear();
                //gridView = null;
                InitGrid();
            }
        }

        private void InitGrid()
        {
            gridView = new TileGridViewElement[width, height];
            TileGridViewElement tile = null;
            uniformGrid.Rows = height;
            uniformGrid.Columns = width;
            //Assigning all tiles accordingly
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tile = new TileGridViewElement();
                    tile.PosX = i;
                    tile.PosY = j;
                    tile.BImage = null;
                    tile.Button.HorizontalAlignment = HorizontalAlignment.Stretch;
                    tile.Button.VerticalAlignment = VerticalAlignment.Stretch;
                    SelectedElementChanged += tile.OnPassImage;
                    uniformGrid.Children.Add(tile.Button);
                    gridView[i, j] = tile;
                }
            }
            //Resize Grid
            uniformGrid.MaxWidth = tile.Width * Width;
            uniformGrid.MaxHeight = tile.Height * Height;

        }

    }

}
