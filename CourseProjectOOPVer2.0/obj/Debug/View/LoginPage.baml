   M S B A M L   `   `   `  ����Q  MCourseProjectOOPVer2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CourseProjectOOPVer2._0.ViewCourseProjectOOPVer2._0.View  5      ,    &CourseProjectOOPVer2._0.View.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CourseProjectOOPVer2._0.View     5        N� Title$  	LoginPage��5	       � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $2 ,pack://application:,,,/styles/regbutton.xaml?�6%   %    5      .��5      � ���#6BBF90.+�5   
   �� $��Center=�6   $��Center=�6.   $	��338��6I   $	��500��6V   
�������$��390,140,390,202q�6u    �� CornerRadius$ 10��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      ShadowDepth$ 0Q�63      Opacity$	 0.8Q�6C   ._�5      � .+�5      �� $&�� Добро пожаловать!��6   $��Center=�64   $	��Top=�6Q   $��20q�6i   $��20(�6u   �� 5      $��Center=�6?   $��40��6\   	 �� TextWrapping$
	 Wrap=�6h   $	��Top=�6}   $	��380��6�   $��	0,101,0,0q�6�   $��20(�6�   ��6   �� *Email+
 �� Mode$
 TwoWay=�.��6�   ��5      �� 5      .R�5      �� $ 12��6%    �� Padding$ 2q�67   $��1q�6C   ���#000000._�5   "   ��  ��Name$ PART_ContentHost��6:   $��0q�6/   6:   5      5      .��5   (   5       G� 5!      -   5         G�Name$ PasswordBox��5!      $��Center=�66   $��40��6S   $	��Top=�6a   $	��380��6y   $��60,181,60,0q�6�   $��20(�6�   ��5"      �� 5#      .R�5$      �� $ 12��6%   $ 2q�67   $��1q�6C   ���#000000._�5%   "   �� $ PART_ContentHost��6:   $��0q�6/   6:   5&      5'      5)      �� 5*      $��Регистрация��6   $
��Left=�6G   $��
60,286,0,0q�6b   $	��Top=�6v   $	��186��6�   $��30��6�      GreenButton#��[  6�   ��6/   �� *Reg+ 5+       �� 
TargetType �� Property �� Value��%^   '��       �� 5,      " ��6    .�5-      ��  �@��CornerRadius$ 5��6=   5.      5/      50      �� 51      $��Вход��6h   $
��Left=�6w   $��255,286,0,0q�6�   $	��Top=�6�   $	��185��6�   $��30��6�   #��[  6�   ��6   �� *Login+��63   ��  �� ElementName$ PasswordBox�� 52      ��%^   '��       �� 53      " ��6    .�54      ��  �@��CornerRadius$ 5��6=   55      56      57      �� 58      $��
Логин��6   $
��Left=�6(   $��	60,73,0,0q�6C   $	��Top=�6V   $��93��6n   $��16(�6y   �� 59      $��Пароль��6   $
��Left=�6)   $��
60,152,0,0q�6D   $	��Top=�6X   $��93��6p   $��16(�6{   �� 5:      $
��Left=�64   $��
60,262,0,0q�6O   $	��Top=�6c   $��24��6{   $	��380��6�   
���  ����6   �� *Status+6�   �� 5;      $
��Left=�6   $��
62,237,0,0q�67   $	��Top=�6K   $��19��6c   $��19��6o    d� 	IsChecked 6z   �� *
SaveUser+$
 TwoWay=� � LayoutTransform 5<      �� 5=       �� ScaleX$	 1.2Q�6)    �� ScaleY$	 1.2Q�66   5?      �� 5@      $1��+Запомнить пользователя��6   $
��Left=�69   $��
90,232,0,0q�6T   $	��Top=�6h   $	��267��6�   $��16(�6�   5A      5B      5C      5D      