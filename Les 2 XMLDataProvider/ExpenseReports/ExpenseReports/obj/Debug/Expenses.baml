   M S B A M L   `   `   `  ����I  EExpenseReports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ExpenseReportsExpenseReports  5          ExpenseReports.Expenses   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ExpenseReports     5        N� Title$  Expenses��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��2��6    $��Center=�64   $��Trebuchet MS)�6O   $
��Bold"�6i   $��18(�6{   ���#0066cc.��6�   Expense Report For:6�   �� 5   
   $��0��6   $��1��6    $��0,0,0,5q�6-   $
��Bold"�6>   .��6P   Name:6W   �� 5   
   $��1��6   $��1��6    $��0,0,0,5q�6-   $
��Bold"�6>   ��6P   ��  �� XPath$ @Name���� 5   
   $��0��6   $��2��6!   $��0,0,0,5q�6.   $
��Bold"�6?   .��6Q   Department:6^   �� 5    
   $��1��6   $��2��6    $��0,0,0,5q�6-   $
��Bold"�6>   ��6P   �� $ @Department��&   System.Windows.Controls.DataGrid  5#   
   $��0��6   $��2��6#   $��3��67      AutoGenerateColumns .  ��6E   �� $ Expense��   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� $ @ExpenseType��6a     5'      $ Amount��6%   $	 50* 6^    65   �� $ @ExpenseAmount��6^   5)      5+      5-      