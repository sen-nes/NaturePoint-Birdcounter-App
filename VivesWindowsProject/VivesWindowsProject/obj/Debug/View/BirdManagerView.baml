   M S B A M L   `   `   `  ����N  JVivesWindowsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:VivesWindowsProject.ViewVivesWindowsProject.View  5      M+clr-namespace:VivesWindowsProject.ViewModelVivesWindowsProject.ViewModel  5      .    (VivesWindowsProject.View.BirdManagerView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      8views&clr-namespace:VivesWindowsProject.View     5      B
viewModels+clr-namespace:VivesWindowsProject.ViewModel     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5        � 	Resources  5       �� DataType4  .VivesWindowsProject.ViewModel.DetailsViewModel*   $VivesWindowsProject.View.DetailsView5  /VivesWindowsProject.ViewModel.EditBirdViewModel+   %VivesWindowsProject.View.EditBirdView4  .VivesWindowsProject.ViewModel.AddBirdViewModel*   $VivesWindowsProject.View.AddBirdView��%�   (��       5	      *, +)(�� 2     5      *, +)(�� d     5      *, +)�� 5	   
   "  6   .R�5
        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��4 �6   �� 5      $��3* �6   .+�5   
   � $��0��5        5       	  Birds �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value��%l  &	        '�� ^     �� 5       65   �� *Birds+ 5        5       $ BirdType��63   5"      �� 5#      " ��6    5$      P� 5%       �@��AlternationIndex$	 0��6L   . �5&      �� 
 � ��
 �����6;   5'      P� 5(       �@��AlternationIndex$	 1��6L   . �5)      �� 
 � ��
 ��ح�6;   5*      5,      5-       � RowDefinitions 5/      �� 50      $��* �6    �� 51      $
��Auto �6    .+�54      ��  �� AlternationCount$ 2��57      $ �� IsSynchronizedWithCurrentItem$
 TrueY�58      $��0��59      ��55      ��  �� Source# [   �� SelectedItem 56      �� *CurrentBird+ �� Mode$ TwoWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5;      /	  )System.Windows.Interactivity.EventTrigger	  5<       	  	EventName$ MouseUp��6%   .
  (System.Windows.Interactivity.TriggerBase 
  Actions. 5=      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *DetailsCommand+5>      ��5A      �� 5B      .R�5C      ��  �� Orientation$ 
Horizontal=�5D      $��5q�5E      .+�5F      �� }�. $��50��5H   !   $��50��5I   !   ��5J   !   �� *
ImageUrl+�� 5L      $��Center=�5N   %   $	��5 0q�5O   %   $��18(�5P   %   ��5M   %   �� *Name+5P   %   5Q      5R       �� 
GroupStyle 5U      (  "System.Windows.Controls.GroupStyle  5V         HeaderTemplate 5W      �� 5X      .R�5Y   "   �� ��5Z   %   �� *Name+��5[   &   �� 5\   *   .�5]   .   �� 
 � ��
 �W�.�6U   �� 5^   .   
 � ��$ 24(�6S   �� 5_   .   
 � ��$
 Thin"�6U   5`   +   5b   #   5c      5e      5g      �� 5i      $��1��5j      $��0 2.5 0 2.5q�5k      $��Add a new bird��5l      ��5m      �� *
AddCommand+5n      �� 5p   
   $��2��5q      $��Stretch=�5r      $��Stretch=�5s      ��5t      �� *CurrentWorkspace+5u      5v      