   M S B A M L   `   `   `  ����O  KLibraryManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LibraryManagementWPF.Views.Books LibraryManagementWPF.Views.Books  5   	   2    ,LibraryManagementWPF.Views.Books.BookDetails   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:LibraryManagementWPF.Views.Books     5   	   A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	     � 
ResizeMode$  NoResize=�5	       � WindowStartupLocation$ CenterOwner=�5
   	    � ShowInTaskbar$ False��5   	   "  Wpf.Ui.Controls.FluentWindow   WindowBackdropType$ Acrylic=�5   	   !   ExtendsContentIntoTitleBar$
 True��5   	      WindowCornerPreference$ Round=�5   	   $	��620��5   	    � Title$ BookDetails��5   	   $	��400��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
     Wpf.Ui.Controls.TitleBar  -   5          Name$ titleBar��5   #   $��0��6   	   Title$	 Book Details��65   
   ShowMaximize$
 False��6J      ShowMinimize$ False��6_      Icon 5         Wpf.Ui.Controls.SymbolIcon  5         Symbol$ BookInformation24=�6    5      � 5   
   -   5         �Name$ formGrid��5   (   $��1��6   $��32q�6    5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5       $
��Auto �6    60   �� 5!      $
��Auto �6    60   �� 5"      $
��Auto �6    60   �� 5#      $
��Auto �6    60   �� 5$      $
��Auto �6    60   .+�5&      �� $��0��6   $��Book Information��6%   $��24(�6=   $
��Bold"�6K   $��0,0,0,16q�6]   6q   �� 5'      $��1��6   $��0,0,0,16q�6&   .+�5(      �� $��	Book Name��6    �� Target 6,   ��  �� ElementName$ tbxName��6U     Wpf.Ui.Controls.TextBox  5)      -   5          Name$ tbxName��5)         PlaceholderText$ Book A��6I    �� 
IsReadOnly$
 True��6b   $|�False��6t    J� IsHitTestVisible$ False��6�   ��6.   ��  �� Path$
 Name�6�   5*      �� 5+      $��2��6   $��0,0,0,16q�6&   .+�5,      �� $
��ISBN��6    6'   �� $ tbxISBN��6P     5-      -   5        $ tbxISBN��5-      $ 111-1-11-111111-1��6I   $
 True��6m   $|�False��6   $ False��6�   ��6.   �� $
 Isbn�6�   5.      �� 5/      $��3��6   $��0,0,0,16q�6&   .+�50      �� $��Published Date��6    61   �� $ tbxName��(  "System.Windows.Controls.DatePicker  51      -   5          Name$ pckerPublishedDate��51   4   $��Right=�6   $��35��6P   $|�False��6�   $ False��6�      SelectedDate 6\   �� $ PublishedDate�6�   52      �� 53      $��4��6   $��Author��6%   $��24(�63   $
��Bold"�6A   $��0,0,8,0q�6S   6f   �� 54      -   5         ��Name$ pnlAuthorDetails��54   &   $��6��6   .+�55      �� $��0,0,0,16q�6   .+�56      �� $��Author Name��6     57      -   5        $ tbxAuthorName��57   !   $ Chris A��6`   $
 True��6z   $|�False��6�   $ False��6�   ��68   �� $
 Name� �� Mode$ TwoWay=�6�   58      �� 59      $��0,0,0,16q�6   .+�5:      �� $��Author Birthday��6     5;      -   5        $ pckerBirthday��5;   !   $ False��6l   $|�False��6�    68   �� $ Birthday�$ TwoWay=�6�   5<      5=      � 5>      $
��Auto��6   $��7��6    $��0,0,0,16q�6-    � ColumnDefinitions 5?      �� 5@      $��* �6'   63   �� 5A      $��16 �6'   64   �� 5B      $��* �6'   63   .+�5D        Wpf.Ui.Controls.Button  -	   5          Name$ btnSave��5D      $��0��6-   $��Stretch=�6=      
Appearance$ Primary=�6[   $��Borrow��6p      Icon 5E        5F      $ 	BookAdd24=�6(   5H        5I      -
   5        $ 	btnCancel��5I      $��2��6/   $��Stretch=�6?   $ 	Secondary=�6]   $��Close��6t   6�   5J      5K      5L      5M      