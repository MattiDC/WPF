   M S B A M L   `   `   `  ����E  APlantenBIS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PlantenBIS
PlantenBIS  5          PlantenBIS.PageDetail   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:PlantenBIS     5        N� Title$  
PageDetail��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� $	��Top=�6   $��7q�6-   $��0��68   .+�5      �� -   5        $��PlantPicture��5      $y�	Collapsed=�6,   ��5      ��  �� XPath$ 	botanical�� �� StringFormat$ images/{0}.jpg���� 5         AchtergrondKleur#��[  6   
�������$��2q�6X    �� CornerRadius$ 5��6l   ._�5      �� $	��200��6   $	��200��6$    �� RadiusX$ 5��61    �� RadiusY$ 5��6=   $��2q�6I   ��5      �� 5       �� ImageSource 6!   �� *Text+	 �� ElementName$	 PlantPicture��5       5!      5"      �� 5$   
   $��1��6   
�������$��2q�66   $ 5��6J   $��7q�6[   ��5%      �� 5&      
 �� Color$
 White��6"    �� Opacity$	 0.2Q�60   ._�5(      �� $	��Top=�6   $��7q�62    �� Orientation$ Vertical=�6=   .+�5)      ��   PlantenText#��[ 6   $��5q�6[   $��30(�6f   ��6=   �� $ common��6f   �� 5*      #��[ 6   $��5q�6^   $��20(�6i   ��6=   �� $ 	botanical��6i   �� 5+      #��[ 6   $��5q�6`   $��14(�6k   $
��Wrap=�6y   ��6=   �� $ description��6y   �� 5,      #��[ 6   $��5q�6Z   $��14(�6e   ��6=   �� $ price��6e   5-      5.      50      51      