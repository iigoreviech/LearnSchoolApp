   M S B A M L   `   `   `  ����I  ELearnSchoolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LearnSchoolAppLearnSchoolApp  5          LearnSchoolApp.UCServices   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:LearnSchoolApp     5      .��5	      �� -   5          ��Name$  border��5	      
�������$��3q�60   
�������$	��600��6\   ._�5
   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� 
�������$��2q�6-   $��5q�6A   $	��200��6L   $	��200��6Y   ._�5      �� -   5         ��Name$ imgServ��5      5      � 5      $��1��6   $��5q�6#    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      .+�5      �� $
��Wrap=�6;   $��20(�6O   $��Comic Sans MS)�6]   ��6   �� *Service.Title+6]   �� 5       �� Orientation$ 
Horizontal=�6   $��1��66   $��0,10,0,0q�6C   .+�5      �� -   5         ��Name$ tbCostDiscount��5       $��Strikethrough{�68   $��17(�6X   $y�	Collapsed=�6f   $��Comic Sans MS)�6}   �� 5      -   5        $ tbCost��5       $��5 0 0 0q�6e   $��17(�6v   $��Comic Sans MS)�6�   ��60   �� *Service.Cost+ �� StringFormat$ {0:N0}��6�   5      �� 5      -   5        $ 
tbDiscount��5      $��2��60   $��14(�6=   $��0,5,0,0q�6K   $��Comic Sans MS)�6\   �� 5      $��3��6   $ 
Horizontal=�6*   $��Bottom=�6C   .+�5       �� -   5         ��Name$ btnEdit��5    K      BtnStyle#��[  6   $	��150��6?   $ ��редактировать��6\   $��	10 0 0 10q�6t   6�   �� 5!      -   5        $ 	btnDelete��5!   ?   #��[  6   $��удалить��6R   $��	10 0 0 10q�6d   6w   5"      5#      5$      5%      5&      