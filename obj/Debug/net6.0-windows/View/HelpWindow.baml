   M S B A M L   `   `   `  ����O  KGPR5100ToolDevAbgabe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GPR5100ToolDevAbgabe.ViewGPR5100ToolDevAbgabe.View  5   	   *    $GPR5100ToolDevAbgabe.View.HelpWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GPR5100ToolDevAbgabe.View     5   	     � Title$  
HelpWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5       $��8* �6   6*   �� 5!      $��* �6   6)    � ColumnDefinitions 5#   
   �� 5$      $��* �6   6+   �� 5%      $��8* �6   6,   �� 5&      $��8* �6   6,   �� 5'      $��* �6   6+   .+�5)   
   � -   5         �Name$ Commands��5)      $��1��6!   $��1��61   .+�5*      �  5+      �� 5,      6&    5.      �� 5/      $��* �6'   63   �� 50      $��2* �6'   64   .+�52      � $��0��6   $��0��6$   .+�53      �� $��	Commands:��6    $��15(�61   $
��Bold"�6?   $��20��6Q   $	��100��6]   $��
30,0,0,330q�6i   6   �� 54       �� 
LineHeight$ 20��6    $B��<Open File
Save File
Save File as
Close File
Quit application��6:   $
��Bold"�55       $��20,30,10,140q�62   �� 56      $.��(/Resources/icons8-ordner-öffnen-500.png��6   $��15��6M   $��15��6X   $��-100,-270,0,0q�6d   6}   �� 57      $(��"/Resources/icons8-speichern-64.png��6   $��15��6H   $��15��6S   $��-100,-230,0,0q�6_   6y   �� 58      $,��&/Resources/icons8-speichern-als-30.png��6   $��15��6L   $��15��6W   $��-100,-190,0,0q�6c   6}   �� 59      $,��&/Resources/icons8-speichern-als-30.png��6   $��15��6L   $��15��6W   $��-100,-150,0,0q�6c   6|   �� 5:      $&�� /Resources/icons8-ausgang-50.png��6   $��15��6F   $��15��6Q   $��-100,-110,0,0q�6]   6w   5;      � 5<      $��0��6   $��1��6$   .+�5=      �� $ 20��6    $����Opens a binary file to create a new map
Saves progress of current project
Saves the file under desired name
Closes current project, load default
Closes the entire application��6:   $	��220��5>       $��10,30,10,140q�6,   5?      5@      5A      � 5B   
   -   5        $ Other��5B      $��2��6   $��1��6.   .+�5C      �� $��15(�6   $
��Bold"�6&   $#��General program description: ��68   6_   �� 5D      $ 20��6   $����The program is a basic level editor. It can use Tiles which can
bemanually exchanged in the /Tiles directory.
The tiles in that directory appear on the left as selectable items.
These can be drawn on the Canvas in the centre.
Furthermore you can select own sizes for the grid that is drawn
and assign it a name. The finished file can be saved as binary
file. You can also load this or other binary files again.��62   $��10,30,10,140q�5E      5F      5G      5H      