using System;
using System.Collections.Generic;
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
* File   : RelayCommand.cs
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
*	
*	Note:
*	This entire class is (almost entirely) copied from evening lecture
******************************************************************************/

namespace GPR5100ToolDevAbgabe.ViewModel
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action commmand;
        private readonly Func<bool> canExecute;

        //ruft 2. ctor mit default wert als Func auf
        public RelayCommand(Action _command) : this(_command, default)
        {

        }
        public RelayCommand(Action _command, Func<bool> _canExecute)
        {
            commmand = _command;
            canExecute = default;
        }

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;

        public void Execute(object parameter) => commmand?.Invoke();
    }

    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action<T> command;
        private readonly Predicate<T> canExecute;
        public RelayCommand(Action<T> _command) : this(_command, default)
        {

        }
        public RelayCommand(Action<T> _command, Predicate<T> _canExecute)
        {
            command = _command;
            canExecute = _canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if(parameter is not T value)
            {
                return false;
            }
            return canExecute?.Invoke(value) ?? true;
        }

        public void Execute(object parameter)
        {
            if (parameter is T value)
            {
                command?.Invoke(value);
            }
        }
    }
}
