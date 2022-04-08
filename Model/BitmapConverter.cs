using GPR5100ToolDevAbgabe.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;
using static GPR5100ToolDevAbgabe.ViewModel.LevelViewModel;
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
        private static BitmapImage bitmapImage = new();
        private static byte[] bitmapImageAsByteArr = null;

        public static byte[] ConvertBitmapImageToByte(this BitmapImage _bitmapImage)
        {
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(_bitmapImage));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                encoder.Save(memoryStream);
                bitmapImageAsByteArr = memoryStream.ToArray();
            }
            return bitmapImageAsByteArr;
        }

        public static BitmapImage ConvertByteArrToBitmapImage(this byte[] _byteArr)
        {
            using (MemoryStream memoryStream = new MemoryStream(_byteArr))
            {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }


    }

}
