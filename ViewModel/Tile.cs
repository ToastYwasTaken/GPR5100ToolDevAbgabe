using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : Tile.cs
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
*	08.04.2022  created
*	
******************************************************************************/
namespace GPR5100ToolDevAbgabe.ViewModel
{
    [Serializable]
        public class Tile
        {
            private BitmapImage bImage;
            public BitmapImage BImage { get => bImage; set => bImage = value; }

        }
}
