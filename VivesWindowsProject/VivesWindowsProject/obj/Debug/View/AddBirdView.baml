   M S B A M L   `   `   `  ����N  JVivesWindowsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:VivesWindowsProject.ViewVivesWindowsProject.View  5      *    $VivesWindowsProject.View.AddBirdView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:VivesWindowsProject.View     5      .��5      �   � ColumnDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $��6 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��5       $��0��6   $��Name:��5!      $��Right=�5"       �� Target 5#      ��  �� ElementName$ nameTxt���� 5%   
   -   5         ��Name$ nameTxt��5&       �� TextWrapping$ WrapWithOverflow=�5(      $��0��5)      $��2��6   ��5*      �� *	Bird.Name+�� 5,   
   $��2��5-      $��0��6   $��Type:��5.      $��Right=�5/       50      �� $ typeTxt���� 52   
   -   5        $ typeTxt��53      $ WrapWithOverflow=�54      $��2��55      $��2��6   ��56      �� *Bird.BirdType+ �� Mode$ TwoWay=��� 58   
   $��4��59      $��0��6   $��Length:��5:      $��Right=�5;       5<      �� $ 	lengthTxt���� 5>   
   -   5        $ 	lengthTxt��5?      $ WrapWithOverflow=�5@      $��4��5A      $��2��6   ��5B      �� *Bird.Length+�� 5D   
   $��6��5E      $��0��6   $��Description:��5F      $��Right=�5G       5H      �� $ descriptionTxt���� 5J   
   -   5        $ descriptionTxt��5K      $ WrapWithOverflow=�5L      $��6��5M      $��2��6   ��5N      �� *Bird.Description+�� 5P   
   $��8��5Q      $��0��6   $��Color:��5R      $��Right=�5S       5T      �� $ colorTxt���� 5V   
   -   5        $ colorTxt��5W      $ WrapWithOverflow=�5X      $��8��5Y      $��2��6   ��5Z      �� *Bird.BaseColor+�� 5\   
   $��10��5]      $��0��6   $��Image:��5^      $��Right=�5_       5`      �� $ imageTxt���� 5b   
   -   5        $ imageTxt��5c      $ WrapWithOverflow=�5d      $��10��5e      $��2��6   ��5f      �� *Bird.ImageUrl+�� 5h   
   $��Center=�5i      $��12��5j      $��3��5k       �� Orientation$ 
Horizontal=�5l      .+�5n      �� $	��Add��5o      ��5p      �� *SaveNewCommand+�� 5r      $
��10 0q�5s      $��Cancel��5t      ��5u      �� *CancelNewCommand+5v      5w      5x      