   M S B A M L   `   `   `  ����E  AMyHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyHospital
MyHospital  5   	       MyHospital.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyHospital     5   	   -   5          � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5	   	   $	��500��5
   	   $	��900��6   ���#181735.��5      �  � RowDefinitions 5   
   �� 5      $��25 �5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � ���#0F0F2D$��2��6$    5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      .+�5+      �� $��
MyHospital��6   
�������$��1��5-      $��Center=�5.      $��Center=�5/      �� 55      -   5        $
��Help��55      
�������$��2��57      $��Center=�58      $��Center=�59       � Cursor$
 Hand��5;      �� 5>      -   5        $��Web-site��5>      
�������$��3��5@      $��Center=�5A      $��Center=�5B      $
 Hand��5D      �� 5G      -   5        $
��Exit��5G      
�������$��0,0,10,0q�67   $��12��6J   $��2��6[   $��10(�6o   ��5H      �� 5I       �� 
TargetType" ��6   .�5J      ��  �� Property � �� �� Value �#FE658467   �� 5K       �@�Cursor$
 Hand��63    �� Triggers 5M      P� 5N      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �5O   "   ��  � �� �#FF4C706?   5P      5R      ��5U      �� 5V       �� 
TargetType" ��6&   .R�5W      �� $��75��6!   $��15��6,    �� CornerRadius$ 9��5X   %   #��z��5Y   %   ._�5Z      �� $��Center=�6/   $��Center=�5[   3   5]      5^      5`      5a      �� 5c   
   $��1��6   $��Center=�6"   $��20q�6=   .+�5d      �� .+�5e      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,20q�66   .+�5f      �� $	��100��6   $��60��6(   $��Resourses/logo.png��64    �� BitmapScalingMode$
 Fant=�6P   �� 5g      $��
MyHospital��6    
�������$��20(�5i      $��Center=�5j      $��10,0,0,0q�5k       5m      �� 5n      $��What is��6   
�������$��25(�5p      $��Center=�5q      �� 5s      $
��your��6   
�������$��25(�5u      $��Center=�5v      �� 5x      $��problem?��6   
�������$��25(�5z      $��Center=�5{      �� 5}      -   5         ��Name$ MyFadingText��5~      
�������$��12(�5�      $��Center=�5�      $
��Wrap=�5�      $��0,15,0,0q�5�      �� 5�      $m�gНаше приложение расчитано на людей абсолютно разного во��6!   �� 6b   $s�mзраста и разработано с целью упрощения жизни больным людям)��6f    � Triggers 5�      :� 5�       :� RoutedEvent$ TextBlock.Loaded��6'   .[�5�      �� .��5�   "   �� .��5�   &   W�  �� 
TargetName$ MyFadingText��5�       �� TargetProperty$ (TextBlock.Opacity)�5�       W� From$	 1.0X�5�      	 W� To$	 0.0X�6    g� Duration$ 0:0:5D�6!    g� AutoReverse .  g� RepeatBehavior$ Forever��5�       5�   #   5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5�      �� -   5        $��Sign Up��5�      
�������$��0,0,10,0q�6>   ��5�      �� 5�      " ��6    .�5�      ��  � �� �#FE65846;   �� 5�       �@�Cursor$
 Hand��67    5�      P� 5�   "   	 �@J�IsMouseOver
 . . �5�   &   ��  � �� �#FF4C706C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��100��6%   $��25��61   $ 12��5�   %   #��z��5�   %   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      �� 5�      -   5        $��Sign In��5�      
���������5�      �� 5�      " ��6    .�5�      ��  � �� �#3938506;   �� 5�       �@�Cursor$
 Hand��67    5�      P� 5�   "   	 �@J�IsMouseOver
 . . �5�   &   ��  � �� �	#FF4B497A6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $	��100��6%   $��25��61   $ 12��5�   %   #��z��5�   %   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      �� 5�   
   $��Resourses/wall.png��6   $ HighQuality=�6,   $��
29,5,39,48q�6Z   $��1��6n   $��1��6~   �� 5�   
   -   5        $"��Мне нужен талон��5�      
������� J� RenderTransformOrigin$ 0.5,0.5&�6>   $��56,389,249,61q�6^   $��1��6u   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�       �� Angle$ 0.202Q�6&   T� 5�      5�      ��5�      �� 5�      " ��6   .�5�      ��  � �� �#39385063   �� 5�       �@�Cursor$
 Hand��6/    5�      P� 5�      	 �@J�IsMouseOver
 . . �5�      ��  � �� �	#FF4B497A6;   5�      5�      ��5�      �� 5�      " ��6"   .R�5�      �� $	��130��6   $��25��6)   $ 12��5�   !   #��z��5�   !   ._�5�      �� $��Center=�6+   $��Center=�5�   %   5�      5�      5�      5�      5�      