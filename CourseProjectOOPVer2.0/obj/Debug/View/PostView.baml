   M S B A M L   `   `   `  ����Q  MCourseProjectOOPVer2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CourseProjectOOPVer2._0.ViewCourseProjectOOPVer2._0.View  5      +    %CourseProjectOOPVer2._0.View.PostView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CourseProjectOOPVer2._0.View     5      $
��auto��5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $6 0pack://application:,,,/styles/nostylebutton.xaml?�6%   %    5      .��5      ��  �� CornerRadius$ 10��6    �� Padding$ 5q�6   
�������$
��auto��6>   $��Center=�6L   $��0,0,-0.4,0.4q�6i   $	��602��6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6      ShadowDepth$ 0Q�6/      Opacity$	 0.8Q�6?   ._�5   
   � 	 � RowDefinitions	 5      �� 5      $��30 �6    �� 5      $	��67* �6    �� 5      $��30 �6    .+�5      �� 
���   �$	��0,1q�6)   $
��Left=�6?   $
��auto��6Z   $��2��6h   $��Stretch=�6y   $	��577��6�   $��
5,30,0,0.4q�6�   ._�5      �� -   5        $��PostText��5      $
��Wrap=�6,   $��0,9.2,0,8.6q�6V   
���   ���6@   �� *Text+6k   5      �� 5      -   5        $��UserName��5      $
��Left=�6E   $��5,1,0,0q�6`   $	��Top=�6q   $	��150��6�   
���   ���6$   �� *UserFullName+6�   �� 5      -   5        $��PubDate��5      $
��Left=�6B   $��	397,1,0,0q�6]   $	��Top=�6p   $	��185��6�   $��Right=�6�   
���   ���6#   �� *
PublicDate+6�   � 5       $��Right=�6   $��26��6/   $��
0,0.9,10,0q�6;   $��2��6O   $	��Top=�6\   $
��auto��6t   
 � ColumnDefinitions
 5"      �� 5#      $
��109* �6'   �� 5$      $
��auto �6'   �� 5%      $	��30* �6'   .+�5'      �� $
��Auto��6   {�.    NonStyle#��[  6S   
�������
�������$��14,0,-0.2,0q�6�   $��1��6�   $��2��6�   ��6)   �� *Like+.��5(      �� $��2��6:   ��6   �� *
LikeStatus+6:   5)      �� 5*      $
��Left=�68   $	��Top=�6S   $
��Left=�6k   $
��auto��6�   $��0,4,8,0q�6�   $��1��6�   $
��auto��6�   $��2��6�   ��6   �� *LikesNumber+6�   �� 5+      $��Right=�6   $
��Auto��65   $��0,0,6,0q�6C   {�. #��[  6h   
�������
�������.��5,      �� $7��1pack://application:,,,/styles/IcnsPic/Comment.png��6   $��2��6W   5-      5.      50      51      52      