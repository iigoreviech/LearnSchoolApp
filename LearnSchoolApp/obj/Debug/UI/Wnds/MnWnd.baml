   M S B A M L   `   `   `  ����I  ELearnSchoolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LearnSchoolAppLearnSchoolApp  5   	       LearnSchoolApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LearnSchoolApp     5   	     � Title$>  8Школа иностранных языков «Learn»��5   	   $	��560��62   $
��1000��6?    � Icon$  /Resources/school_logo.png��6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $
��500* �6    � ColumnDefinitions 5   
   �� 5      $
��150* �6   �� 5      $
��680* �6   .+�5   
   � $��0��6   ���#E7FABF J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      ShadowDepth$ 10Q�63      Opacity$	 0.2Q�6D   5      �� 5   
   $��0��6   $ ��/Resources/school_logo.png��6   $��7q�6A   �� 5   
    K� ZIndex$ 1��6   $��1��6&   ���#E7FABF 5        5      $ 20Q�6#   $ 10Q�63   $	 0.2Q�6D   .+�5      �� -   5        	 ��Name$	 	btnToMain��5      $��Главная��6(      BtnStyle#��[  6:   $��0 10 0 0q�6\   6n   �� 5      -   5        $	 btnServices��5      $��Услуги��6*   #��[  6;   $��0 10 0 0q�6]   6o   �� 5      $��Клиенты��6   #��[  6'   $��0 10 0 0q�6I   �� 5      -   5        $	 btnExit��5      $��
Выход��6'   #��[  67   $��	0 210 0 0q�6Y   6l   5       �� 5!   
   $��1��6   
 �� Orientation$
 
Horizontal=�6%   .+�5"      �� $>��8Школа иностранных языков «Learn»��6     TxtBlkcStyle#��[ 6@   $��25(�6f   $��	180 0 0 0q�6t   5#       � 5$   
   -   5          �Name$ frame��5$      $��2��6   $��2��6/     � NavigationUIVisibility$ Hidden=�6<   6^   5%      5&      