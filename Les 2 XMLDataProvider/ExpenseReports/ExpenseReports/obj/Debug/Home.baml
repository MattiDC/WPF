   M S B A M L   `   `   `  ����I  EExpenseReports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ExpenseReportsExpenseReports  5          ExpenseReports.Home   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ExpenseReports     5        N� Title$
  Home��5	       � 	Resources 5         labelNameStyle �� 
TargetType �� Property �� Value  labelDepartmentStyle��%D  &	        &	 �     �� 5   
   " ��6'   .�5      ��  � ��
 ���_�6+   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6-   .�5      ��  � ��
 ��+��6+   �� 5       � ��$ DemiBold"�6+   �� 5       � ��$ 12(�6)   5      5      .��5      � $��
10,0,10,10q�6    5   
     ExpenseDataSource � Source � XPath  nameItemTemplate �� Orientation �� XPath	 �� StringFormat
 �� ElementName��%�  &	       &	 E     7   7  � 5      $ Data/employees.xml?�68   $ Expenses��6T   6g   �� 5      .R�5      �� $ 
Horizontal=�6   .+�5      �� $��	ImageName��6    $y�	Collapsed=�61   ��6H   �� $ @Department��$	 png/{0}.png���� 5       $��75��6   ��6'   �� *Text+$
 	ImageName���� 5!      $ Vertical=�6!   .+�5"      �� 8��  ��6    �� $ @Name��6@   �� 5#      8�� ��6    �� $ @Department��6F   5$      5%      5&      5'       � ColumnDefinitions 5*   
   �� 5+       � RowDefinitions 5-   
   �� 5.      $
��Auto �6   �� 5/      �� 50      $
��Auto �6   .+�53   
   �� $��0��6   $��0��6!   $��35��6.    �� Padding$ 5q�6:   ���#4E87D4._�54      �� $��Center=�6   
�������.��6B   	Employees6M   55      �� 57   
   -   5        $��ListBoxEmployees��57      $��0��6*   $��1��6:   #��[ 59   	   ��58   	   ��  �� Source# [ $ Person��59   	   �� 5<   
   -   5        $��0��5<      $��2��6!   $��0,10,0,0q�6.   $	��125��6@   $��25��5=   	   $��Right=�6   .��6F   View6L   5>      5?      