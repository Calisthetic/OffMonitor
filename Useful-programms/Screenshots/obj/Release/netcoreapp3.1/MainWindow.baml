   M S B A M L   `   `   `  ���� F  BScreenshots, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ScreenshotsScreenshots      Screenshots.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Screenshots     -     � WindowStyle$  SingleBorderWindow=� � Title$ Screen��$	��213��$	��316��$	��213��$	��316�� � Icon$ /target.png��.���  � RowDefinitions �� $	��150 ��� $��24 �.+��� -    ��Name$ 
takeScreen��$	��150��$��0��$	��300��
���   �$��Take screen��$��20(�$��DemiBold"�$��0,0,0,0q�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �������  � �� ��  �� 
TargetType" ��.R��� #��z��._��� $��Center=�$��Center=�	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value$
 True��. ���  � �� ��  �� Color$	 Red�� �� Opacity$
 0.95Q��� -    ��Name$ txbPath��$��16(�$��24��$��1��