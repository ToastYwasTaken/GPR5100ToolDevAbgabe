using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/*****************************************************************************
* Project: GPR5100ToolDevAbgabe
* File   : ViewModelBase.cs
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
* Note:
* This entire class is (almost entirely) copied from evening lecture
******************************************************************************/

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyIfChanged([CallerMemberName] string propertyname = default) => PropertyChanged?.Invoke(this, new(propertyname));
        protected void RaisePropertyIfChanged<T>(ref T field, in T value, [CallerMemberName] string propertyName = default) => RaisePropertyIfChanged(ref field, value, default, propertyName);
        protected void RaisePropertyIfChanged<T>(ref T field, in T value, Action<T> changed , [CallerMemberName] string propertyName = default)
        {
            if (!field.Equals(value))
            {
                return;
            }
            field = value;
            changed?.Invoke(value);
            RaisePropertyIfChanged(propertyName);
        }

    }
}
