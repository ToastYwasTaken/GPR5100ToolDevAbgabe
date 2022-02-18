using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace GPR5100ToolDevAbgabe.ViewModel
{

    public class TileSelectionElement
    {
        public BitmapImage Tile { get; set; }
        public Uri uri { get; set; }
        public TileSelectionElement(string _path)
        {
            uri = new Uri(_path, UriKind.Absolute);
            Tile = new BitmapImage(uri);
        }
    }
}
