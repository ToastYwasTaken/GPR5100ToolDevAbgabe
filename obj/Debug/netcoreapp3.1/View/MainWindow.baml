   M S B A M L   `   `   `  ����O  KGPR5100ToolDevAbgabe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GPR5100ToolDevAbgabe.ViewGPR5100ToolDevAbgabe.View  5   	   O,clr-namespace:GPR5100ToolDevAbgabe.ViewModelGPR5100ToolDevAbgabe.ViewModel  5   	   G(clr-namespace:GPR5100ToolDevAbgabe.ModelGPR5100ToolDevAbgabe.Model  5   	   Q-clr-namespace:GPR5100ToolDevAbgabe.PropertiesGPR5100ToolDevAbgabe.Properties  5   	   *    $GPR5100ToolDevAbgabe.View.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GPR5100ToolDevAbgabe.View     5   	   B	viewmodel,clr-namespace:GPR5100ToolDevAbgabe.ViewModel     5   	   :model(clr-namespace:GPR5100ToolDevAbgabe.Model     5   	   D
properties-clr-namespace:GPR5100ToolDevAbgabe.Properties     5   	     � Title$  
MainWindow��5!   	   $	��450��6   $	��800��6)    � DataContext 5   	   ��    	VMLocator �� Source# [   �� Path$ VMMain� � ContextMenu 5#      �� 5$   
   .@�5%      m� 5'      5(      .��5*      ]�  � 	Resources 5+   
     LinearGradientBrush �� 
StartPoint �� EndPoint � Color	 � Offset��%�   &	       �� 5,      $
 0, 0&�6>   $
 0, 1&�6P   .��5-      � $ 	#FF3D3D3D��6   $	 0Q�61   � 5.      $
 Gray��6   $		 1.5Q�6,   � 5/      $ 	LightGray��6   $	 1Q�61   50      51      .+�52   
   o� $	��Top=�6   #��[ 6$   $��Center=�6V   .@�53      m� 
 m� Icon
 54      �� 55      $%��/Resources/icons8-datei-500.png��6   6G    � ToolTip 57      �� 58      $
��File��6    6.   .@�5;      m� $	��New��6    m� Command 6(   �� *FileCommand_NewFile+
 5<      �� 5=      $(��"/Resources/icons8-dokument-500.png��6    6N   5?      m� 5@      $
��Open��6    6)   �� *FileCommand_OpenFile+
 5A      �� 5B      $.��(/Resources/icons8-ordner-öffnen-500.png��6    6S   5D      m� 5E      $
��Save��6    6)   �� *FileCommand_SaveFile+
 5F      �� 5G      $(��"/Resources/icons8-speichern-64.png��6    6N   5I      m� 5J      $��Save as��6    6,   �� *FileCommand_SaveFileAs+
 5K      �� 5L      $,��&/Resources/icons8-speichern-als-30.png��6    6R   5N      �� 5O      6   m� 5P      $��Settings��6    6-   �� *#!ProgramCommand_OpenSettingsWindow+
 5Q      �� 5R      $0��*/Resources/icons8-dienstleistungen-500.png��6    6V   5T      �� 5U      6   m� 5V      $��Quit Application��6    65   �� *!ProgramCommand_CloseApplication+
 5W      �� 5X      $&�� /Resources/icons8-ausgang-50.png��6    6L   5Z      5[      m� 5\      
 5]      �� 5^      $*��$/Resources/icons8-bearbeiten-500.png��6   6L    5`      �� 5a      $
��Edit��6    6.   .@�5c      m� $
��Undo��6    6)   �� *EditCommand_Undo+6P   m� 5d      $
��Redo��6    6)   �� *EditCommand_Redo+6P   5e      m� 5f      
 5g      �� 5h      $#��/Resources/icons8-view-32.png��6   6E    5j      �� 5k      $
��View��6    6.   5m      m� 5n      
 5o      �� 5p      $%��/Resources/icons8-window-64.png��6   6G    5r      �� 5s      $��Window��6    60   5u      m� 5v       6   �� *ProgramCommand_Help+
 5w      �� 5x      $#��/Resources/icons8-help-30.png��6   6E    5z      �� 5{      $
��Help��6    6.   5}      5~      �� 5   
   $��Bottom=�6   6.   � 5�   
    � ColumnDefinitions 5�      �� 5�      $��* �6#   6/   �� 5�      $��5 �6#   6/   �� 5�      $��5* �6#   60   �� 5�      $��* �6#   6/    � RowDefinitions 5�      �� 5�      $��* �6    6-   �� 5�      $��7* �6    6.   �� 5�      $��* �6    6-   .+�5�      �� $��0��6   $��1��6(   $��3��68   $��12��6I   $��Stretch=�6T   $��Stretch=�6r   6�   � 5�      -   5         �Name$ TileSelection��5�      $��0��6*   $��0��6;   $��3��6H   .+�5�      �� -   5         ��Name$ TileSelectionListView��5�       �� SelectedIndex 6:   �� *SelectedElementIndex+��5�      �� 5�      .R�5�      A�  A� Columns$ 5��6*   $��Stretch=�66   $��Stretch=�6T   6r   5�      ��5�      �� 5�      .R�5�      ��  �� Orientation$ Vertical=�6)   $��Stretch=�6@   $��Stretch=�6\   .+�5�   "   �� $��Center=�6@   $��Center=�6]   ��6(   �� *Tile+6z   5�      5�      5�      5�      � 5�      -   5        $ PlaceHolder��5�      $��2��6(   $��0��69   6H   � 5�      -   5        $ 
MainEditor��5�      $��2��6'   $��1��67   .+�5�      �� $��5q�6   5�      5�      � 5�      -   5        $ ErrorShowBox��5�      $��2��6)   $��3��69   6H   � 5�      -   5        $ ToolSelection��5�      $��3��6*   $��0��6;   $��3��6H   6[   5�      5�      5�      