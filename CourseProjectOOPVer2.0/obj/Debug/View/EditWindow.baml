   M S B A M L   `   `   `  ����Q  MCourseProjectOOPVer2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CourseProjectOOPVer2._0.ViewCourseProjectOOPVer2._0.View  5   	   -    'CourseProjectOOPVer2._0.View.EditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CourseProjectOOPVer2._0.View     5   	   -   5          � Title$   ��5   	   $��390.047��6   $��336.296��6#    � 
ResizeMode$ NoResize=�64    J� SnapsToDevicePixels .  � Icon$&  pack://application:,,,/logo1.png��6�    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $2 ,pack://application:,,,/styles/regbutton.xaml?�6%   %    5      .��5      � .+�5   
   �� $0��*Изменить фото страницы��6   $
��Left=�62   $	��Top=�6M   $	��310��6e   $��	10,10,0,0q�6q   $��27��6�      GreenButton#��[  6�   $��12(�6�   ��6�   �� *EdPic+ 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 5��65   5      5      5      �� 5   
   $��Пол:��6   $
��Left=�6   $��	10,42,0,0q�6:   $	��Top=�6M   $��92��6e   �� 5   
   $ ��Дата рождения:��6   $
��Left=�6)   $��	10,89,0,0q�6D   $	��Top=�6W   $	��107��6o   �� 5   
   $��Страна: ��6   $
��Left=�6#   $��
10,140,0,0q�6>   $	��Top=�6R   $	��107��6j   �� 5   
   $��Город:��6   $
��Left=�6!   $��
10,194,0,0q�6<   $	��Top=�6P   $	��107��6h   �� 5   
   $��О себе:��6   $
��Left=�6"   $��
10,249,0,0q�6=   $	��Top=�6Q   $��92��6i   
 J� RenderTransformOrigin$
 0.028,0.644&�6t   �� 5   
   $
��Left=�6   $��
122,42,0,0q�6.   $	��Top=�6B   $	��190��6Z   $��24��6f    �� Text 6r   �� *Sex+.@�5      �� 	Муж.6   �� 5      	Жен.6   5       (  "System.Windows.Controls.DatePicker  5!   
   $
��Left=�6   $��
122,89,0,0q�60   $	��Top=�6D   $	��190��6\   $��2q�6h   |�.     SelectedDate 6�   �� *
BirthDay+5"      �� 5#   
   $
��Left=�6   $��23��6-   $��122,141,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��190��6z   ��6�   �� *	Country+ �� Mode$ TwoWay=��� 5$   
   $
��Left=�6   $��23��6-   $��122,195,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��190��6z   ��6�   �� *City+$ TwoWay=��� 5%   
   $
��Left=�6   $��122,253,0,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $��53��6n   $	��190��6z   $��1,1,1,1q�6�   ��6�   �� *AboutMyself+$ TwoWay=��� 5&   
   $��Сохранить��6   $
��Left=�6%   $	��Top=�6@   $	��302��6X   $��
10,311,0,0q�6d   $��29��6x   $��12(�6�   ��6�   �� *SaveChanges+ 5'      ��%^   '��       �� 5(      " ��6   .�5)      ��  �@��CornerRadius$	 5��65   5*      5+      ��5,      �� 5-       �� ResourceKey$ GreenButton��6!   5/      51      52      