   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DefaultDataGridRowStyle  �� 
TargetType)   #System.Windows.Controls.DataGridRow �� Property �� Value �� Opacity  ControlFillColorDefault �� Color   SystemFillColorCriticalBrush �� 
TargetType ��Name J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions	 � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter
    
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter    DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!   HeadersVisibilityConverter'  !System.Windows.VisualStateManager   VisualStateGroups%	  System.Windows.VisualStateGroup 	  States 
  System.Windows.VisualState 
  
Storyboard �� TargetProperty g� Duration  SystemAccentColor	 �� To	 W� To�� 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %z  &	        �� 5      "    6,   .�5   
   ��  � �� 5      �� 5      $	 0.0Q�6"   # �  60   5	      �� 5
   
    � ��
 ���� 6(   �� 5   
    � ��$ False��6&   �� 5   
    �@J�SnapsToDevicePixels$
 True��60   �� 5   
    �@�OverridesDefaultStyle$
 True��62   �� 5   
    �@=�ErrorTemplate 65   Z� �� 5   
    �@  ValidationErrorTemplate 5      �� 5      .R�5      �� $��2,0,0,0q�5      $��Center=�5      #���  5      $��!��5      5      5      �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� $ 
DGR_Border��5      #��z��5      #��z��5       #��z��5!      $
 True��5"      ._�5#         5$      �� 5%   "   $
��Auto �63   �� 5&   "   $��* �63   	 5(      �� 5)   "   $��* �60   �� 5*   "   $
��Auto �60   .+�5,        $��1��5-   !   #��z
 5.   !   # z 5/   !     50      $��1��51   !   $��1��52   !   #y�z 54   !    53   !   �� *AreRowDetailsFrozen+# Z # Z  �� "  54   !     55      $��0��56   !   $��2��57   !   $��0��58   !   $ Vertical=�59   !   y�5:   !   �� *HeadersVisibility+# Z # Z  �� "  5;       5<      	  5=      CommonStates��. 5>   "   
  
Normal��6.   
  5A   "   Normal_AlternatingRow��6.   
  5C   "   Normal_Selected��. 5D   &   �� .��5E   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5F   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.66�   5G   '   5H   #   
  5J   "   Unfocused_Selected��. 5K   &   �� .��5L   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5M   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.66�   5N   '   5O   #   
  5Q   "   Normal_Editing��. 5R   &   �� .��5S   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5T   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.66�   5U   '   5V   #   
  5X   "   MouseOver_Editing��. 5Y   &   �� .��5Z   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5[   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.86�   5\   '   5]   #   
  5_   "   MouseOver_Unfocused_Editing��. 5`   &   �� .��5a   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5b   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.86�   5c   '   5d   #   
  5f   "   Unfocused_Editing��. 5g   &   �� .��5h   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5i   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.66�   5j   '   5k   #   
  5m   "   	MouseOver��. 5n   &   �� .��5o   *   W� $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.86�   5p   '   5q   #   
  5s   "   MouseOver_Selected��. 5t   &   �� .��5u   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5v   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.86�   5w   '   5x   #   
  5z   "    MouseOver_Unfocused_Selected��. 5{   &   �� .��5|   *   �� $0 *(Panel.Background).(SolidColorBrush.Color)�69   $ 0D�6�   # �  6�   W� 5}   *   $2 ,(Panel.Background).(SolidColorBrush.Opacity)�6:   $ 0D�6�    0.86�   5~   '   5   #   5�      5�      5�      5�      5�      5�      