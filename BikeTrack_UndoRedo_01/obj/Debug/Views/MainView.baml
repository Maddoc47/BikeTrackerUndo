   M S B A M L   `   `   `  ����P  LBikeTrack_UndoRedo_01, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BikeTrack_UndoRedo_01.Properties BikeTrack_UndoRedo_01.Properties  5   	   $    BikeTrack_UndoRedo_01.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   Cresource.clr-namespace:BikeTrack_UndoRedo_01.Properties     5   	   $	��400��5	   	   $	��600��5
   	     � Title$  MVVM Light Application��5   	   .��5      � -   5         �Name$ 
LayoutRoot��5      
���k���.+�5   
   �� $��18(�6   $
��Bold"�5      
�������$	��Top=�5      $
��Left=�5      $��20,10q�5      $
��Wrap=�5      ��5      �� *WelcomeTitle+5      � 5   
   $��10q�6   $
��Left=�6    $��Bottom=�6;   
���2͚�.+�5      �� 
���   �$��2q�6)   $	��Top=�6=   ._�5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ SaveLoadButtonStack��5       $ 
Horizontal=�6=   .+�5      �� -   5         ��Name$ 
SaveButton��5       0   *BikeTrack_UndoRedo_01.Properties.Resources   SaveButtonHeader#��Z 64   $��60��6m   $��20��6x   $��2q�6�   �� 5      -   5        $ 
LoadButton��5          LoadButtonHeader#��Z 64   $��60��6m   $��20��6x   $��2q�6�   5      �� 5       -   5        $ UndoRedoButtonsStack��5    !   $ 
Horizontal=�6?   .+�5!      �� -   5        $ 
UndoButton��5!   %      UndoButtonHeader#��Z 6Y   $��60��6�   $��20��6�   $��2q�6�   ��69   �� *UndoCommand+6�   �� 5"      -   5        $ 
RedoButton��5"   %      RedoButtonHeader#��Z 69   $��60��6r   $��20��6}   $��2q�6�   5#      5$      5%      5&      &   System.Windows.Controls.DataGrid  5'   
   -   5        	  Name$	 	TrackGrid��5(      
   AutoGenerateColumns
 .  
�������   CanUserAddRows .    CanUserResizeColumns .    CanUserDeleteRows . $��Right=�5.         VerticalGridLinesBrush
 ��  �$	��430��51      ��5/      �� *TrackCollection+   Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      -	   5        
DateColumn��   
HeaderDate,  &System.Windows.Controls.DataGridColumn   Header# Z 55   9   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6k   �� *Date+  56      -
   5        LocationColumn��   HeaderLocation# Z 56   =    6s   �� *
Location+  57      -   5        LengthColumn��   HeaderLength# Z 57   ;    6o   �� *Length+  58      -   5        
TimeColumn��   
HeaderTime# Z 58   9    6k   �� *Time+  59      -   5        TimePerKmColumn��   HeaderTimePerKm# Z 59   ?    6v   �� *	TimePerKm+5;      5<      5=      