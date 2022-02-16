using System;
using System.Collections.Generic;
using System.Text;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : Tile.cs
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
* ----------------------------
*	16.02.2022  created
******************************************************************************/

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class TileViewModel : ViewModelBase
    {
        public int fieldHeight, fieldWidth;

        public TileViewModel(int _fieldHeight, int _fieldWidth)
        {
            fieldHeight = _fieldHeight;
            fieldWidth = _fieldWidth;
            for(int i = 0; i < _fieldHeight; i++)
            {
                for (int j = 0; j < _fieldWidth; j++)
                {

                }
            }
        }

    }

    public class InteractableTile
    {
        public int tileHeight, tileWidth;

        public InteractableTile(int _tileHeight, int _tileWidth)
        {
            tileHeight = _tileHeight;
            tileWidth = _tileWidth;
        }
    }

}
