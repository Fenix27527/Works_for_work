   M S B A M L   `   `   `  ����V  Rучёт персонала, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:учёт_персоналаучёт_персонала  5   	   /    )учёт_персонала.WindowWorkers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:учёт_персонала     5   	   -   5          � Title$  	WindowRab��5   	   $	��450��6   $	��800��6(    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��5* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $\��VC:\Users\User\Desktop\курсовая РПМ\визуал\фон персонал.jpg��6   $
��Auto��6T   $
��Auto��6b   $��3��6o   $��6��6�   �� 5   
   ._�5      �� -   5        $��
But_Nazad1��5      $��
Назад��6'   $��15(�67   $
��Bold"�6E   $	��100��6W   $��30��6c   6o   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TABLEPersonal��5   /      AutoGenerateColumns .  $��0��6F   $��1��6W   $��3��6d    J� Opacity$	 0.7Q�6x   
���OO/�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Номер��6@   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Number+6O     5      $	 ФИО��6=   $

 Auto 6J    6%   �� *FIO+6J     5      $ 	 Подразделение��6G   $

 Auto 6^    6%   �� *Podrazdelenie+6^     5      $	 Должность��6B   $

 Auto 6U    6%   �� *
Dolznost+6U     5      $	 ИНН��6=   $

 Auto 6J    6%   �� *INN+6J     5       $	 
Адрес��6?   $

 Auto 6N    6%   �� *Adres+6N     5!      $	 Дата приёма��6E   $

 Auto 6Z    6%   �� *Data_priema+6Z     5"      $	 
Семья��6?   $

 Auto 6N    6%   �� *Semia+6N     5#      $	 Образование��6E   $

 Auto 6Z    6%   �� *Obrazovanie+6Z     5$      $	 Награды��6A   $

 Auto 6R    6%   �� *	Nagradi+6R   5&      �� 5'   
   -   5         ��Name$ updateButton_Per��5'      $��Обновить��6+   $��15(�6>   $
��Bold"�6L   $	��100��6^   $��30��6j   $��2��6�   $��0��6�   �� 5(   
   -   5        $ deleteButton_Per��5(      $��Удалить��6+   $��15(�6=   $
��Bold"�6K   $	��100��6]   $��30��6i   $��2��6�   $��1��6�   �� 5)   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�69   $��Center=�6R   .+�5*      �� -   5         ��Name$ tb_Poisk��5*      $	��500��6(   $��30��64   �� 5+      -   5        $ Poisk��5+      $��
Поиск��6$   $��15(�64   $
��Bold"�6B   $	��100��6T   $��30��6`   6l   5,      5-      5.      