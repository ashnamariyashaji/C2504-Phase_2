   M S B A M L   `   `   `  ����I  EItenaryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ItenaryProjectItenaryProject  5   	       ItenaryProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ItenaryProject     5   	   -   5          � Title$  Itenary Pages��5   	   $	��450��6   $	��800��6,   .��5	      �� .+�5
   
   �� -   5         ��Name$ btnNew��5
      $��New Itenary��6!    �� Left$ 35��67   
 �� Top$ 44��6H   $��Center=�6X   $	��Top=�6u   $	��108��6�   $��40��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdIternaries��5      $	��244��5      $	��670��6!   $ 40��6-   $	 105��6>      
IsReadOnly .    SelectionMode$ Single=�5   &      AreRowDetailsFrozen .    AutoGenerateColumns .  ��5   +   �� *
Iternaries+	 �� SelectedItem	 5      �� *SelectedItenary+
 �� Mode$
 TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $
 Time��6%    63   �� *Time+  5      $ Itenary��6%    66   �� *ItenaryName+  5      $ About��6%    64   �� *About+  5      $ Price��6%    64   �� *Price+5      �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $ 42��61   $	 364��6B   $	��108��6S   $��40��6_   $
��Left=�6k   $	��Top=�6�   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $	 160��65   $	 364��6G   $	��108��6X   $��40��6d   $
��Left=�6p   $	��Top=�6�   ��6�   �� *DeleteCommand+5      5      