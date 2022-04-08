using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : TileGridViewElement.cs
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
*	22.03.2022  created
*	
******************************************************************************/
namespace GPR5100ToolDevAbgabe.ViewModel
{
    [Serializable]
    public class TileGridViewElement : Tile
    {
        private int posX;
        public int PosX { get => posX; set => posX = value; }
        private int posY;
        public int PosY { get => posY; set => posY = value; }

        private Button button;
        public Button Button { get => button; set => button = value; }

        private int height = 30;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }       
        private int width = 30;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        
        private BitmapImage selectedImage;
        public BitmapImage SelectedImage
        {
            get => selectedImage;
            set => selectedImage = value;
        }

        public TileGridViewElement()
        {
            button = new Button();
            button.Width = width;
            button.Height = height;
            button.Click += OnGridClick;
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.VerticalAlignment = VerticalAlignment.Center;
            //button.Margin = ;
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
