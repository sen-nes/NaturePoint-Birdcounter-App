   M S B A M L   `   `   `  ����N  JVivesWindowsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:VivesWindowsProject.ViewVivesWindowsProject.View  5      .    (VivesWindowsProject.View.BirdCounterView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      8local&clr-namespace:VivesWindowsProject.View     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      .��5      �   � 	Resources  5   
    	  Birds �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%h   &	        �� 5       61   �� *Birds+ 5	        5
      $ BirdType��6/   5      5      .+�5   
   �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      ��5      ��  �� Source# [   �� SelectedItem 5      �� *CurrentBird+ �� Mode$ TwoWay=���5      �� 5      .R�5      � $��5q�5       � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $��30 �6/   �� 5      $
��Auto �6/   �� 5      $��30 �6/   �� 5      $
��Auto �6/   �� 5      $��30 �6/   �� 5      $
��Auto �6/   �� 5       $��30 �6/   �� 5!      $
��Auto �6/   �� 5"      $��30 �6/   .+�5%      �� $��0��5&      }�. $	��100��5(      $	��100��5)      ��5*      �� *
ImageUrl+�� 5,      $��2��5-      $��Center=�5/      $	��5 0q�50      $��18(�51      ��5.      �� *Name+51      �� 53      $��50��54      $��50��55      $��4��56      $��  -  ��57      ��58      �� *DecreaseCommand+�� 5:      $��Center=�5;      $��6��5<      ��5=      �� *Count+$ TwoWay=��� 5?      $��50��5@      $��50��5A      $��8��5B      $��  +  ��5C      ��5D      �� *IncreaseCommand+5E      5F      	 �� 
GroupStyle	 5I      (  "System.Windows.Controls.GroupStyle  5J      
   HeaderTemplate
 5K      �� 5L      .R�5M      �� ��5N   %   �� *Name+��5O   &   �� 5P   *   .�5Q   .   ��  �� Property � �� �� Value
 �W�.�6U   �� 5R   .    � ��$ 24(�6S   �� 5S   .    � ��$
 Thin"�6U   5T   +   5V      5W      5Y      5[      5\      5]      