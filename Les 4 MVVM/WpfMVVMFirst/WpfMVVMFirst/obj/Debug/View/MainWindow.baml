   M S B A M L   `   `   `  ����G  CWpfMVVMFirst, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfMVVMFirst.ViewWpfMVVMFirst.View  5   	   ?$clr-namespace:WpfMVVMFirst.ViewModelWpfMVVMFirst.ViewModel  5   	   "    WpfMVVMFirst.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfMVVMFirst.View     5   	   :	viewmodel$clr-namespace:WpfMVVMFirst.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��300��6   $	��400��6)    � 	Resources 5      .  (WpfMVVMFirst.ViewModel.CustomerViewModel   CustomerViewModel �� 
TargetType �� Property �� Value��%�  &	        '��      '�� �     '�� �      5   
   6&   �� 5   
   " ��6   .�5      ��  � ��$ 	10,12,0,0q�6'   �� 5       � ��$
 Left=�64   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 	10,12,0,0q�6'   �� 5       � ��$
 Left=�64   �� 5       � ��$ 16(�6)   �� 5       � ��$ 25��6'   �� 5       � ��$	 200��6&   5      �� 5   
   " ��6   .�5      ��  � ��$ 	10,12,0,0q�6'   �� 5       � ��$
 Left=�64   �� 5       � ��$ 16(�6)   �� 5        � ��$ 25��6'   �� 5!       � ��$	 200��6&   5"      5#      .��5%      � $��Center=�6   $��Center=�6&    � DataContext# [  5&       � RowDefinitions 5(   
   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $��* �6    � ColumnDefinitions 5/   
   �� 50      $
��Auto �6   �� 51      $��* �6   .+�54   
   �� $��Name:��6   �� 55   
   $��1��6   $��Amount:��6!   �� 56   
   $��2��6   $��Country:��6!   �� 57   
   $��3��6   $
��Tax:��6!   �� 59   
   $��1��6   ��6"   �� *Customer.Name+�� 5:   
   $��1��6   $��1��6"   ��6/   �� *Customer.Amount+�� 5;   
   $��1��6   $��2��6"   ��6/   �� *Customer.Country+�� 5<   
   $��1��6   $��3��6$   ��61   �� *Customer.Tax+�� 5>   
   $��1��6   $��4��6!   $��Calculate Tax��6.   ��6F   �� *CalculateTaxCommand+5A      5B      