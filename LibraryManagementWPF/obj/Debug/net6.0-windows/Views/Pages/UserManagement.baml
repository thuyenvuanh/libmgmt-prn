   M S B A M L   `   `   `  ����O  KLibraryManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LibraryManagementWPF.Views.Pages LibraryManagementWPF.Views.Pages  5      Q-clr-namespace:LibraryManagementWPF.ConvertersLibraryManagementWPF.Converters  5      5    /LibraryManagementWPF.Views.Pages.UserManagement   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:LibraryManagementWPF.Views.Pages     5      C	converter-clr-namespace:LibraryManagementWPF.Converters     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design    
Background#  �   5        TextFillColorPrimaryBrush   
Foreground# �  5       N� 
Foreground# �  5       N� Title$ User Management��5      
 � Tag$ User Management��6    � 	Resources 5      3   -LibraryManagementWPF.Converters.RoleConverter  roleConverter��%   &	         5   
   6"   5      .��5      � -   5         �Name$ 
grRootPage��5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5        	 ��Name$	 	pageTitle��5   =   $��16q�6   $��0��6    $��0��60   $��32(�6P   $
��Bold"�6^   
 �� Left$
 16��6p   
 �� Top$ 16��6�   
���   �User Management6�   �� 5   
   $��1��6   $��0��6%   $��Right=�62    �� Orientation$ 
Horizontal=�6N   .+�5        Wpf.Ui.Controls.Button  -   5          Name$ 
btnRefresh��5      $��0 8 16 8q�6,   $��Refresh��6>      
Appearance$ 	Secondary=�6P      Icon 5         Wpf.Ui.Controls.SymbolIcon  5          Symbol$ ArrowClockwise24=�6$   5"        5#      -   5        $ btnAdd��5#      $��0 8 16 8q�6(   $	��Add��6:   $ Primary=�6H    5$        5%      $ Add24=�6$   5'        5(      -   5        $ btnEdit��5(      $��0 8 16 8q�6)   $
��Edit��6;   $ 	Secondary=�6J    5)        5*      $ Edit24=�6$   5,        5-      -   5        $ btnDel��5-      $��0 8 16 8q�6(   $��Delete��6:   $ Danger=�6K   ���	#E4FFFFFF 5.        5/      $ Delete24=�6$   51      52      �� 53   
   $��1��6   $��0��6"   $��2��62   $��Right=�6F   $ 
Horizontal=�6b   $��Center=�6{   $��	16,8,16,8q�6�   .+�54      �� $��Search:��6   $��Center=�6O   $��0,10,0,0q�6l    �� Target 6&   ��  �� ElementName$ 	tbxSearch��6l     Wpf.Ui.Controls.TextBox  55      -   5        $��	tbxSearch��55         PlaceholderText$ example@mail.com��6*   $��	16,0,16,0q�6M   $��35��6`   $	��250��6l   6z     56      -   5        $��	btnSearch��56      $��Search��6)   $��35��6R   57        Wpf.Ui.Controls.DataGrid  58   
   -	   5          Name$ 
dgUserList��5:      $��
16,0,16,16q�58      &   System.Windows.Controls.DataGrid   AutoGenerateColumns$ False��6*   $��2��59      $��2��6#   $��0��67      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5:   *      
IsReadOnly$
 True��5;        �� IsTextSearchCaseSensitive$
 True��6(   $
��True��5<      $
��Auto=�5=        DefaultDataGridRowStyle   RowStyle# [ 5>      $
��Auto=�5?         Columns 5@      0	  *System.Windows.Controls.DataGridTextColumn	  5A      ,
  &System.Windows.Controls.DataGridColumn 
  CanUserReorder$ False��6<    
  DisplayIndex$ 0��6S    
  Header$ UserID��6d    
  
IsReadOnly$
 True��6t    
  
Visibility$ Visible=�6�     
  Width$  * 6�   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6%   �� *Id+6�   	  5B      $ False��6?   $ 1��6V   $ Email��6g   $
 True��6v   $  * 6�   ! 6%   �� *Email+6�   	  5C      $ False��6B   $ 2��6Y   $ Password��6j   $
 True��6|   $ Hidden=�6�   $  * 6�   ! 6%   �� *
Password+6�   	  5D      $ False��6h   $ 3��6   $
 Role��6�   $
 True��6�   $  * 6�   ! 6%   �� *Role+" �� 	Converter#" [ 6�   	  5E      $ False��6E   $ 4��6\   $ BorrowItems��6m   $
 True��6�   $ 	Collapsed=�6�   $  * 6�   ! 6%   �� *BorrowItems+6�   5G      5H      5I      