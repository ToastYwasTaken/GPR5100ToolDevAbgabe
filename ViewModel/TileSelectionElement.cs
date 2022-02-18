using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : TileSelectionElement.cs
* Date   : 16.02.2022
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
* _____________________
*	16.02.2022  created
******************************************************************************/
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
