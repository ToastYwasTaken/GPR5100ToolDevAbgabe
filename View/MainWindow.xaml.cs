using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace GPR5100ToolDevAbgabe.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /** Custom Command + shortcut
        public static RoutedUICommand CustomUICommandCloseApplication = new RoutedUICommand("CloseApplicationShortcut", "CloseApp", typeof(MainWindow), new InputGestureCollection
        {
            new KeyGesture(Key.Escape, ModifierKeys.Alt)
        });
        */
        //public static RoutedUICommand CustomUICommandRemoveCharacter = new RoutedUICommand("Remove Character", "RemoveCharacter", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandChangeCharacter = new RoutedUICommand("Change Character", "ChangeCharacter", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandOpenFile = new RoutedUICommand("Open File", "OpenFile", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandNewFile = new RoutedUICommand("New File", "NewFile", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandSaveFile = new RoutedUICommand("Save File", "SaveFile", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandSaveAsFile = new RoutedUICommand("Save File as", "SaveFileAs", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandCloseWindow = new RoutedUICommand("Close Window", "CloseWindow", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandUndo = new RoutedUICommand("Undo", "Undo", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandRedo = new RoutedUICommand("Redo", "Redo", typeof(MainWindow));
        //public static RoutedUICommand CustomUICommandHelp = new RoutedUICommand("Help", "Help", typeof(MainWindow));

        //private ObservableCollection<CharacterData> characterList = new ObservableCollection<CharacterData>();

        //private CharacterData defaultCharacter;

        public MainWindow()
        {
            InitializeComponent();
            //characterList.Add(new CharacterData { Name = "New Orc", Race = "Orc", IsMale = true, Health = 200, Attack = 30, Defense = 10 });
            //characterList.Add(new CharacterData { Name = "New Elve", Race = "Elve", IsMale = false, Health = 120, Attack = 10, Defense = 30 });
            //characterList.Add(new CharacterData { Name = "New Human", Race = "Human", IsMale = false, Health = 100, Attack = 20, Defense = 20 });

            ////Characters from own List
            //characterListBox.ItemsSource = characterList;

            //defaultCharacter = FindResource("DefaultCharacter") as CharacterData;
        }

    //    private void OnAddButtonClicked(object sender, RoutedEventArgs e)
    //    {
    //        characterList.Add(new CharacterData(defaultCharacter));
    //    }

    //    private void OnRemoveButtonClicked(object sender, RoutedEventArgs e)
    //    {
    //        if (characterListBox.SelectedIndex < 0 || characterListBox.SelectedIndex >= characterList.Count) return;
    //        characterList.RemoveAt(characterListBox.SelectedIndex);
    //    }

    //    private void OnChangeButtonClicked(object sender, RoutedEventArgs e)
    //    {
    //        if (characterListBox.SelectedIndex < 0 || characterListBox.SelectedIndex >= characterList.Count) return;
    //        //Explicit
    //        characterNameTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
    //        characterHealthTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
    //        characterAttackTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
    //        characterDefenseTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
    //        characterIsMaleTextBox.GetBindingExpression(CheckBox.IsCheckedProperty).UpdateSource();

    //        // One time / one way
    //        CharacterData characterData = characterList[characterListBox.SelectedIndex];
    //        characterData.Name = characterNameTextBox.Text;
    //        characterData.Health = int.Parse(characterHealthTextBox.Text);
    //        characterData.Attack = int.Parse(characterAttackTextBox.Text);
    //        characterData.Defense = int.Parse(characterDefenseTextBox.Text);
    //        characterData.IsMale = characterIsMaleTextBox.IsChecked == true;


    //    }

    //    private void CanExecuteListModifiers(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = characterListBox.SelectedIndex >= 0 || characterListBox.SelectedIndex < characterList.Count;
    //    }

    //    #region Dockpanel Buttons / Commands
    //    private void OnNewButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void OnOpenButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {
    //        OpenFileDialog openFileDialog = new OpenFileDialog();
    //        if (openFileDialog.ShowDialog() == true)
    //        {
    //            TextBox txt = new TextBox();
    //            txt.Text = File.ReadAllText(openFileDialog.FileName);
    //        }
    //    }

    //    private void OnSaveButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void OnSaveAsButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void OnCloseButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {
    //        Application.Current.MainWindow.Close();
    //    }

    //    private void OnUndoButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void OnRedoButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void OnHelpButtonClicked(object sender, ExecutedRoutedEventArgs e)
    //    {

    //    }

    //    private void CanExecuteNewFile(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteOpenFile(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteSaveFile(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteSaveFileAs(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteCloseWindow(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = Application.Current.MainWindow != null;
    //    }

    //    private void CanExecuteUndo(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteRedo(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }

    //    private void CanExecuteHelp(object sender, CanExecuteRoutedEventArgs e)
    //    {
    //        e.CanExecute = true;
    //    }
    //    #endregion
    }

    //class CharacterData : INotifyPropertyChanged
    //{
    //    private string name = "";
    //    public string Name
    //    {
    //        get => name;
    //        set => ChangeProperty(ref name, value, nameof(Name));
    //    }

    //    private string race = "";
    //    public string Race
    //    {
    //        get => race; 
    //        set => ChangeProperty(ref race, value, nameof(Race));
    //    }

    //    private bool isMale = false;
    //    public bool IsMale
    //    {
    //        get => isMale;
    //        set => ChangeProperty(ref isMale, value, nameof(isMale));
    //    }
    //    private int health = 0;
    //    public int Health
    //    {
    //        get => health;
    //        set => ChangeProperty(ref health, value, nameof(Health));
    //    }

    //    private int attack = 0;
    //    public int Attack
    //    {
    //        get => attack;
    //        set => ChangeProperty(ref attack, value, nameof(Attack));
    //    }
    //    private int defense = 0;

    //    public int Defense
    //    {
    //        get => defense;
    //        set => ChangeProperty(ref defense, value, nameof(Defense));
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
        
    //    //Copy ctor
    //    public CharacterData(CharacterData other)   
    //    {
    //        name = other.name;
    //        race = other.race;
    //        health = other.health;
    //        attack = other.attack;
    //        defense = other.defense;
    //        isMale = other.isMale;
    //    }
    //    public CharacterData() { }
    //    private void ChangeProperty<T>(ref T _oldValue, T _newValue, string _propertyName)
    //    {
    //        if (_oldValue.Equals(_newValue)) return;
    //        _oldValue = _newValue;
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propertyName));
    //    }

    //    public override string ToString()
    //    {
    //        return $"{name} - {race} - {isMale} - {health} - {attack} - {defense}";
    //    }

    //}

    //class BooleanToMaleFemaleConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return (bool)value ? "male" : "female";
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return value.ToString().ToLower().Equals("male");
    //    }
    //}    
    //class SelectedIndexToVisibilityConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return (int)value >= 0 ? Visibility.Visible : Visibility.Hidden;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return (Visibility)value == Visibility.Visible ? 1 : 0;
    //    }
    //}

}
