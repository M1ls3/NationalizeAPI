   M S B A M L   `   `   `  ����I  ENationalizeAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NationalizeAPINationalizeAPI  5   	       NationalizeAPI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NationalizeAPI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)    � Icon$ 	/200w.gif��65   ��5	      �� 5
   
    �� ImageSource$ /background.jpg��6    j� Stretch$ UniformToFill=�63   .��5      � .+�5   
   �� -   5         ��Name$ 
tabControl��5      ��5      �� 5      .@�5      �� $��Take API��6   ��5      �� 5      $# /button backgruond orange.jpg��6!   .��5      � .+�5      �� -   5         ��Name$ name_textBox��5      $��Center=�64   $��0,39,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��240��6�   $��16(�6�   $&�� Segoe UI Variable Small Semibold)�6�   �� 5      -   5         ��Name$ 
name_label��5      $��Name:��60   $
��Left=�6@   $��	77,10,0,0q�6[   $	��Top=�6n   $��16(�6�   $&�� Segoe UI Variable Small Semibold)�6�   
�������6�   �� 5      -   5        $ nationalize_label��5      $�� ��67   $��Center=�6B   $	��Top=�6_   $	��229��6w   $	��346��6�   $��0,80,0,0q�6�   
�������6�   �� 5      -   5         ��Name$ execute_button��5      $��EXECUTE��65   $��Center=�6G   $��	0,318,0,0q�6d   $	��Top=�6w   $��48��6�   $	��186��6�   $��16(�6�   $(��"Segoe UI Variable Display Semibold)�6�   ��5      �� 5      $" /button backgruond green.jpg��6)   5      5      5      �� 5       $��Database��6   ��5!      �� 5"      $# /button backgruond orange.jpg��6!   .��5$      � 	 � ColumnDefinitions	 5%      �� 5&      �� 5'      .+�5)      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 nationalize_dataGrid��5)      $��	0,26,0,32q�6h   
�������   HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   AlternatingRowBackground �	#FF36353A   RowBackground �	#FF2C2D31��6{   Z� ��6�   Z�    ColumnHeaderStyle 5*      �� 5+       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�5,   "   ��  �� Property � �� �� Value �	#FF211F256?   �� 5-   "    � ��
 �����6?   �� 5.   "    � ��$
 Bold"�6?   �� 5/   "    � ��$ 12(�6=   �� 50   "    � ��$ 25��6;   �� 51   "    � ��$ 5,3,5,3q�6<   52      54        55      -   5        $
 country_dataGrid��55      $��	0,26,0,32q�6d   $��1��6w   
 �����
 �����   ClipboardCopyMode$
 None=�6�    �	#FF36353A �	#FF2C2D31��6�   Z� ��6�   Z�  56      �� 57      "  6$   .�58   "   ��  � �� �	#FF211F256?   �� 59   "    � ��
 �����6?   �� 5:   "    � ��$
 Bold"�6?   �� 5;   "    � ��$ 12(�6=   �� 5<   "    � ��$ 25��6;   �� 5=   "    � ��$ 5,3,5,3q�6<   5>      ��5@      �� 5A       �� Color$ White��6.    �� Opacity$ 1Q�6<   5C      �� 5D      -   5        $ nationalize_label_db��5D      $��Nationalize��6:   $
��Left=�6P   $	��Top=�6k   $
��Bold"�6�   
�������6�   �� 5E      -	   5        $ country_label��5E      $��Country info��63   $
��Left=�6J   $	��Top=�6e   $��1��6}   
�������$
��Bold"�6�   5F      5G      5H      5J      5K      