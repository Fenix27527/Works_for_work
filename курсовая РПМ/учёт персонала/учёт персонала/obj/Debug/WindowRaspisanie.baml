   M S B A M L   `   `   `  ����V  Rучёт персонала, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:учёт_персоналаучёт_персонала  5   	   2    ,учёт_персонала.WindowRaspisanie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:учёт_персонала     5   	   -   5          � Title$  WindowRaspisanie��5   	   $	��450��6"   $	��800��6/    � WindowState$ 	Maximized=�5	   	    � WindowStyle$
 None=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��5* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $`��ZC:\Users\User\Desktop\курсовая РПМ\визуал\фон расписание.jpg��6   $
��Auto��6V   $
��Auto��6d   $��3��6q   $��6��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TABLERaspisanie��5   /      AutoGenerateColumns .  $��0��6H   $��1��6Y   $��3��6f    J� Opacity$	 0.7Q�6z   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Номер��6@   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Number+6O     5      $ 	 Подразделение��6G   $

 Auto 6^    6%   �� *Podrazdelenie+6^     5      $	 Должность��6B   $

 Auto 6U    6%   �� *
Dolznost+6U     5      $(	 "Кол-во сотрудников��6@   $

 Auto 6\    6%   �� *Kol_vo+6\     5      $+	 %Тарифная ставка, руб��6?   $

 Auto 6]    6%   �� *Tarif+6]   5       �� 5!   
   -   5         ��Name$ Nazad3��5!      $��
Назад��6!   $��15(�61   $
��Bold"�6?   $	��100��6Q   $��30��6]   6i   �� 5"   
   -   5        $ updateButton_Rasp��5"      $��Обновить��6,   $��2��6?   $��15(�6L   $
��Bold"�6Z   $	��100��6l   $��30��6x   6�   �� 5#   
   -   5        $ deleteButton_Rasp��5#      $��Удалить��6,   $��2��6>   $��1��6K   $��15(�6[   $
��Bold"�6i   $	��100��6{   $��30��6�   6�   �� 5$   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�69   $��Center=�6R   .+�5%      �� -   5         ��Name$ tb_Poisk��5%      $	��500��6(   $��30��64   �� 5&      -   5        $ Poisk��5&      $��
Поиск��6$   $��15(�64   $
��Bold"�6B   $	��100��6T   $��30��6`   6l   5'      5(      5)      