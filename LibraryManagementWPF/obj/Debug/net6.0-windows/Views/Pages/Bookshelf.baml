   M S B A M L   `   `   `  ����O  KLibraryManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LibraryManagementWPF.Views.Pages LibraryManagementWPF.Views.Pages  5      Q-clr-namespace:LibraryManagementWPF.ConvertersLibraryManagementWPF.Converters  5      0    *LibraryManagementWPF.Views.Pages.Bookshelf   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:LibraryManagementWPF.Views.Pages     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5      =	converter-clr-namespace:LibraryManagementWPF.Converters  5      -   5           ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5	        TextFillColorPrimaryBrush   
Foreground# �  5
       N� 
Foreground# �  5       N� Title$ My Bookshelf��5      
 � Tag$ My Bookshelf��6    � 	Resources 5      @   :LibraryManagementWPF.Converters.RemainingDateBookConverter  RemainingDateConverter;   5LibraryManagementWPF.Converters.ReturnedDateConverter  ReturnedDateConverter��%:   &	       &	        5   
   6/     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	pageTitle��5   =   $��16q�6   $��0��6    $��0��60   $��32(�6P   $
��Bold"�6^   
���   �$��My Bookshelf��6�   �� 5   
   $��1��6   $��16q�6"    �� Orientation$ 
Horizontal=�6.   .+�5        Wpf.Ui.Controls.Button  -   5        	  Name$	 
btnRefresh��5      $��Refresh��6,   $��0 0 8 0q�6>   
   Icon
 5         Wpf.Ui.Controls.SymbolIcon  5         Symbol$ ArrowClockwise24=�6$   5        5       -   5        $	 	btnReturn��5       $��Return��6+      
Appearance$ Primary=�6<   $	��8 0q�6Q   6^   �� 5!      -   5        $��chboxReturnBooks��5!   E   $��Include returned books��6   $	��8,0q�68   6�   5"        Wpf.Ui.Controls.DataGrid  5#   
   -   5          Name$ dgvBorrowedBook��5%      $��
16,0,16,16q�5#      &   System.Windows.Controls.DataGrid   AutoGenerateColumns$ False��6*   $��2��5$      $��0��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5%   '      
IsReadOnly$
 True��5&        �� IsTextSearchCaseSensitive$
 True��6    $
��True��5'      $
��Auto=�5(        DefaultDataGridRowStyle   RowStyle# [ 5)      $
��Auto=�5*         Columns 5,      0	  *System.Windows.Controls.DataGridTextColumn	  5-      ,
  &System.Windows.Controls.DataGridColumn 
  CanUserReorder$ False��6R    
  DisplayIndex$ 0��6i    
  Header$ 	Book Name��6z    
  
IsReadOnly$
 True��6�    
  Width$ * 6�    
  MinWidth$	 500Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ BookNavigation.Name�6�   	  5.      $ False��6R   $ 1��6i   $ 	Book ISBN��6z   $
 True��6�    
  
Visibility$ Visible=�6�   $ * 6�    6%   �� $ BookNavigation.Isbn�6�   	  5/      $ False��6F   $ 2��6]   $ Borrowed Date��6n   $
 True��6�   $ * 6�    6%   �� *BorrowedDate+6�   	  50      $ False��6@   $ 3��6W   $ Period (Week)��6h   $
 True��6   $ Visible=�6�   $ * 6�    6%   �� *Period+6�   	  51      $ False��6n   $ 4��6�   $ Remaining Days��6�   $
 True��6�   $ Visible=�6�   $ * 6�    6%   �� *.+ �� 	Converter# [ 6�   	  52      $ False��6x   $ 5��6�   $ Returned Date��6�   $
 True��6�   $ Visible=�6�   $ * 6�    6%   �� *ReturnedDate+# [ 6�   54      55      56      