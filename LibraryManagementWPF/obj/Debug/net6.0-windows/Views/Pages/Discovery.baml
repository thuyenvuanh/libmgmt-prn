   M S B A M L   `   `   `  ����O  KLibraryManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LibraryManagementWPF.Views.Pages LibraryManagementWPF.Views.Pages  5      0    *LibraryManagementWPF.Views.Pages.Discovery   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:LibraryManagementWPF.Views.Pages     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5
        TextFillColorPrimaryBrush   
Foreground# �  5       N� 
Foreground# �  5       N� Title$ 	Discovery��5      
 � Tag$ 	Discovery��6   .��5      � -   5         �Name$ RootPage��5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5         ��Name$ 	pageTitle��5   =   $��16q�6   $��0��6    $��0��60   $��32(�6P   $
��Bold"�6^   
���   �$��	Discovery��6�   �� 5   
   $��Right=�6   	 �� Orientation$	 
Horizontal=�61   $��1��6J   $��0��6Z   $��16q�6g   .+�5        Wpf.Ui.Controls.Button  -   5        
  Name$
 
btnRefresh��5   *   $��Refresh��6      
Appearance$ 	Secondary=�6>   $��35��6U   $��0 0 16 0q�6a      Icon 5         Wpf.Ui.Controls.SymbolIcon  5         Symbol$ ArrowClockwise24=�6$   5      �� 5      $��Search:��6   $��Center=�6S   $
��Auto��6n   $��0,4,0,0q�6|    �� Target 6&   ��  �� ElementName$ tbxSearchBook��6|     Wpf.Ui.Controls.TextBox  5       -   5          Name$ tbxSearchBook��5    %   $	��300��6      PlaceholderText$ Search book...��6<   $	��8 0q�6]   $��35��6j     5!      -   5        $
 	btnSearch��5!   J   $��Search��6   $ Primary=�6)   $��35��6>   6]   5"      �� 5#   
   -   5         ��Name$ pnlBookSelected��5#      $��1��6.   $	 
Horizontal=�6;   $��0��6T   $��2��6d   $
��16 0q�6x   .+�5$        -   5        $
 	btnBorrow��5$   <   
�������$��Borrow��6+   $ Success=�6O   $��0 0 8 0q�6d    5%        5&      $ 	BookAdd24=�6$   5(        5)      -   5        $
 
btnDetails��5)   *   $��Details��6   $	��8,0q�6>    5*        5+      $ BookInformation24=�6$   5-      5.        Wpf.Ui.Controls.DataGrid  5/   
   -	   5          Name$ dgvBook��51      $��2��5/      $��0��6#   $��2��63   $��16q�50      &   System.Windows.Controls.DataGrid   AutoGenerateColumns$ False��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 51         
IsReadOnly$
 True��52        �� IsTextSearchCaseSensitive$
 True��6    $
��True��53      $
��Auto=�54        DefaultDataGridRowStyle   RowStyle# [ 55      $
��Auto=�56         Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,	  &System.Windows.Controls.DataGridColumn 	  CanUserReorder$ False��6<    	  DisplayIndex$ 0��6S    	  Header$ Book ID��6d    	  
IsReadOnly$
 True��6u    	  
Visibility$ Visible=�6�    	  Width$
 Auto 6�     	  MinWidth$	  100Q�6�   1
  +System.Windows.Controls.DataGridBoundColumn! 
  Binding! 6%   �� *Id+6�     59      $ False��6>   $ 1��6U   $ 	Book Name��6f   $
 True��6y   $ * 6�   $	  500Q�6�   ! 6%   �� *Name+6�     5:      $ False��6>   $ 2��6U   $ 	Book ISBN��6f   $
 True��6y   $ Visible=�6�   $ * 6�   ! 6%   �� *Isbn+6�     5;      $ False��6G   $ 3��6^   $ Published Date��6o   $
 True��6�   $ * 6�   ! 6%   �� *PublishedDate+6�     5<      $ False��6O   $ 4��6f   $ Author��6w   $
 True��6�   $ Visible=�6�   $ * 6�   ! 6%   �� *AuthorNavigation.Name+6�     5=      $ False��6J   $ 5��6a   $ AuthorNavigation��6r   $
 True��6�   $ 	Collapsed=�6�   $ * 6�   ! 6%   �� *AuthorNavigation+6�     5>      $ False��6E   $ 6��6\   $ BorrowItems��6m   $
 True��6�   $ 	Collapsed=�6�   $ * 6�   ! 6%   �� *BorrowItems+6�   5@      5A      5B      