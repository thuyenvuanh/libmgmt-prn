   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   O KLibraryManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LibraryManagementWPF.Views.Books LibraryManagementWPF.Views.Books 5   	   .   (LibraryManagementWPF.Views.Books.AddBook   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   :local.clr-namespace:LibraryManagementWPF.Views.Books  5   	     � 
ResizeMode$  NoResize=�5
   	    � WindowStartupLocation$ CenterOwner=�5   	    � ShowInTaskbar$ False��5   	   "  Wpf.Ui.Controls.FluentWindow   WindowBackdropType$ Acrylic=�5   	   !   ExtendsContentIntoTitleBar$
 True��5   	      WindowCornerPreference$ Round=�5   	   $	��690��5   	    � Title$ AddBook��5   	   $	��400��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
     Wpf.Ui.Controls.TitleBar  -   5          Name$ titleBar��5   #   $��0��6   	   Title$	 Add New Book��65   
   ShowMaximize$
 False��6J      ShowMinimize$ False��6_      Icon 5         Wpf.Ui.Controls.SymbolIcon  5         Symbol$ 	BookAdd24=�6    5      � 5   
   -   5         �Name$ formGrid��5   (   $��1��6   $��32q�6    5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5       $
��Auto �6    60   �� 5!      $
��Auto �6    60   �� 5"      $
��Auto �6    60   �� 5#      $
��Auto �6    60   �� 5$      $
��Auto �6    60   �� 5%      $
��Auto �6    60   .+�5'      �� $��0��6   $��New Book��6%   $��24(�65   $
��Bold"�6C   $��0,0,0,16q�6U   6i   �� 5(      $��1��6   $��0,0,0,16q�6&   .+�5)      �� $��	Book Name��6    �� Target 6,   ��  �� ElementName$ tbxName��6U     Wpf.Ui.Controls.TextBox  5*      -   5          Name$ tbxName��5*         PlaceholderText$ Book A��6I   ��6.   ��  �� Path$
 Name�6I   5+      �� 5,      $��2��6   $��0,0,0,16q�6&   .+�5-      �� $
��ISBN��6    6'   �� $ tbxISBN��6P     5.      -   5        $ tbxISBN��5.      $ 111-1-11-111111-1��6I   ��6.   �� $
 Isbn�6I   5/      �� 50      $��3��6   $��0,0,0,16q�6&   .+�51      �� $��Published Date��6    61   �� $ tbxName��6Z   (  "System.Windows.Controls.DatePicker  52      -   5          Name$ pckerPublishedDate��52   4   $��Right=�6   $��35��6P      SelectedDate 6\   �� $ PublishedDate�53      �� 54      $��4��6    �� Orientation$ 
Horizontal=�6&   $��0,0,0,16q�6?   .+�55      � ��6   �� *ActualWidth+$ formGrid�� � ColumnDefinitions 56      �� 57      $
��Auto �6+   6:   �� 58      $��* �6+   67   �� 59      $
��Auto �6+   6:   .+�5;      �� $��0��6    $��Author��60   $��24(�6>   $
��Bold"�6L   $��0,0,8,0q�6^   6q   "  Wpf.Ui.Controls.ToggleSwitch  5<      -   5          Name$ tglNewAuthor��5<   K   $��1��6&   $��
New Author��66   6�   5=      5>      �� 5?      -   5         ��Name$ pnlSelectAuthor��5?   &   $��5��6   $��0,0,0,16q�6?   .+�5@      �� $��Search Author��6    60   �� $ sbxAuthorSearch��$  Wpf.Ui.Controls.AutoSuggestBox  5A      -   5          Name$ sbxAuthorSearch��5A   $   6=   5B      �� 5C      -	   5        $ pnlNewAuthor��5C   &   $��6��6   .+�5D      �� $��0,0,0,16q�6   .+�5E      �� $��Author Name��6     5F      -
   5        $ tbxAuthorName��5F   !   $ Chris A��6`   ��68   �� $
 Name� �� Mode$ TwoWay=�6`   5G      �� 5H      $��0,0,0,16q�6   .+�5I      �� $��Author Birthday��6     5J      -   5        $ pckerBirthday��5J   !      FirstDayOfWeek$ Monday=�6l      IsTodayHighlighted$
 True��6�    68   �� $ Birthday�$ TwoWay=�6�   5K      5L      � 5M      $
��Auto��6   $��7��6    $��0,0,0,16q�6-    5N      �� 5O      $��* �6'   63   �� 5P      $��16 �6'   64   �� 5Q      $��* �6'   63   .+�5S        Wpf.Ui.Controls.Button  -   5          Name$ btnSave��5S      $��0��6-   $��Stretch=�6=      
Appearance$ Primary=�6[   $
��Save��6p   6     5T      -   5        $ 	btnCancel��5T      $��2��6/   $��Stretch=�6?   $ 	Secondary=�6]   $��Cancel��6t   6�   5U      5V      5W      5X      