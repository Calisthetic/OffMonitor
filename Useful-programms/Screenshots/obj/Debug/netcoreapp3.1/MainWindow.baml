   M S B A M L   `   `   `  ����F  BScreenshots, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ScreenshotsScreenshots  5   	       Screenshots.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Screenshots     5   	   -   5          � WindowStyle$  SingleBorderWindow=�5   	    � Title$ Screen��5	   	   $	��213��6   $	��316��6(   $	��213��67   $	��316��6`    � Icon$ /target.png��6o   .��5
      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��24 �6   .+�5   
   �� -   5         ��Name$ 
takeScreen��5   �   $	��150��6   $��0��6   $	��300��6+   
���   �$��Take screen��6J   $��20(�6`   $��DemiBold"�6n   $��0,0,0,0q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   5      5      	 �� Triggers	 5      P� 5      
 P� Property
 �@J�IsMouseOver P� Value$
 True��69   . �5      ��  � �� 5   "   �� 5    &    �� Color$	 Red��66    �� Opacity$
 0.95Q�6B   5"      5#      5%      5'      �� 5(   
   -   5         ��Name$ txbPath��5(      $��16(�6#   $��24��61   $��1��6=   5)      5*      