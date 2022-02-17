using System;
using System.Collections.Generic;
using System.Text;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : Converter.cs
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
namespace GPR5100ToolDevAbgabe.Model
{

    public class ConverterModel
    {
        public ConverterModel()
        {

        }
        public virtual object ConvertService(object _param)
        {
            return new object();
        }
    }
    /// <summary>
    /// Converter for width of Grid to row amount
    /// </summary>
    public class WidthToRowsConverter : ConverterModel
    {
        public override object ConvertService(object _param)
        {
            return base.ConvertService(_param);
        }
    }

}
