using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class TileGridViewElement : Tile
    {
        private int posX;
        public int PosX { get => posX; set => posX = value; }
        private int posY;
        public int PosY { get => posY; set => posY = value; }

        private Button button;
        public Button Button { get => button; set => button = value; }

        private BitmapImage selectedImage;

        public TileGridViewElement()
        {
            button = new Button();
            button.Click += OnGridClick;
        }

        public void OnGridClick(object sender, RoutedEventArgs args)
        {
            button.Content = new Image { Source = selectedImage };
        }

        public void OnPassImage(BitmapImage _bitmapImage)
        {
            selectedImage = _bitmapImage;
        }
    }
}
