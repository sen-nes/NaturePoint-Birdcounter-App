   M S B A M L   `   `   `  ����N  JVivesWindowsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:VivesWindowsProject.ViewVivesWindowsProject.View  5      +    %VivesWindowsProject.View.EditBirdView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:VivesWindowsProject.View     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��6 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   .+�5    
   �� $��WrapWithOverflow=�5!      $��0��5"      $��3��6   $��Center=�5#      $��36(�5%      ��5$      �� *	Bird.Name+5%      �� 5'   
   $��2��5(      $��0��6   $��Type:��5)      $��Right=�5*       �� Target 5+      ��  �� ElementName$ typeTxt���� 5-   
   -   5         ��Name$ typeTxt��5.       �� TextWrapping$ WrapWithOverflow=�5/      $��2��50      $��2��6   ��51      �� *Bird.BirdType+�� 53   
   $��4��54      $��0��6   $��Length:��55      $��Right=�56       57      �� $ 	lengthTxt���� 59   
   -   5        $ 	lengthTxt��5:      $ WrapWithOverflow=�5;      $��4��5<      $��2��6   ��5=      �� *Bird.Length+�� 5?   
   $��6��5@      $��0��6   $��Description:��5A      $��Right=�5B       5C      �� $ descriptionTxt���� 5E   
   -   5        $ descriptionTxt��5F      $ WrapWithOverflow=�5G      $��6��5H      $��2��6   ��5I      �� *Bird.Description+�� 5K   
   $��8��5L      $��0��6   $��Color:��5M      $��Right=�5N       5O      �� $ colorTxt���� 5Q   
   -   5        $ colorTxt��5R      $ WrapWithOverflow=�5S      $��8��5T      $��2��6   ��5U      �� *Bird.BaseColor+�� 5W   
   $��10��5X      $��0��6   $��Image:��5Y      $��Right=�5Z       5[      �� $ imageTxt���� 5]   
   -   5        $ imageTxt��5^      $ WrapWithOverflow=�5_      $��10��5`      $��2��6   ��5a      �� *Bird.ImageUrl+�� 5c   
   $��Center=�5d      $��12��5e      $��3��5f       �� Orientation$ 
Horizontal=�5g      .+�5i      �� $
��Save��5j      ��5k      �� *SaveCommand+�� 5m      $
��10 0q�5n      $��Cancel��5o      ��5p      �� *CancelCommand+5q      5r      5s      