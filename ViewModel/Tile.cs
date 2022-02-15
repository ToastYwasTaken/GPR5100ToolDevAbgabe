using System;
using System.Collections.Generic;
using System.Text;

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class Tile
    {
        public int tileHeight, tileWidth;

        public Tile(int _tileHeight, int _tileWidth)
        {
            tileHeight = _tileHeight;
            tileWidth = _tileWidth;
        }
    }

    public class TileField
    {
        public int fieldHeight, fieldWidth;

        public TileField(int _fieldHeight, int _fieldWidth)
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
}
