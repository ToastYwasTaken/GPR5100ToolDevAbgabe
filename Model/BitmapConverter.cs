using GPR5100ToolDevAbgabe.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : BitmapConverter.cs
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
*	05.04.2022  changed functionality to BitmapConverter methods
******************************************************************************/
namespace GPR5100ToolDevAbgabe.Model
{
    public static class BitmapConverter
    {
        public static string ConvertGridElementsToString(this List<TileGridViewElement> _gridViewElementsList)
        {
            string str = "";
            string individualSeperator = ",";   //seperates posX, posY and Image
            string tileGridViewElementSeperator = "/";  //seperates to next element
            for (int i = 0; i < _gridViewElementsList.Count; i++)
            {
                string posXstr = _gridViewElementsList[i].PosX.ToString();
                string posYstr = _gridViewElementsList[i].PosY.ToString();
                string selectedImageStr = _gridViewElementsList[i].SelectedImage.ToString();
                str += posXstr + individualSeperator + posYstr + individualSeperator + selectedImageStr + tileGridViewElementSeperator;
            }
            return str;
        }

        public static List<TileGridViewElement> ConvertStringToGridViewElementsList(this string _stringToConvert)
        {
            string[] tileGridViewElements = _stringToConvert.Split("/");
            List<TileGridViewElement> tileGridViewElementsList = new();
            for (int i = 0; i < tileGridViewElements.Length; i++)
            {
                string[] elementData = tileGridViewElements[i].Split(",");
                TileGridViewElement tileGridViewElement = new();
                tileGridViewElement.PosX = int.Parse(elementData[0]);  //posX
                tileGridViewElement.PosY = int.Parse(elementData[1]);  //posY
                tileGridViewElement.SelectedImage = ConvertStringToBitmapImage(elementData[2]);  //BitmapImage
                tileGridViewElementsList.Add(tileGridViewElement);
            }
            return tileGridViewElementsList;
        }

        public static BitmapImage ConvertStringToBitmapImage(string _imageString)
        {
            byte[] bytes = Convert.FromBase64String(_imageString);
            using MemoryStream memoryStream = new(bytes);
            BitmapImage bitmapImage = new();

            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.StreamSource = memoryStream;
            bitmapImage.EndInit();

            return bitmapImage;
        }
    }

}
