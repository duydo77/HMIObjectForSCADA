   M S B A M L   `   `   `  ����F  BdemoWinForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HMITankHMITank  5          HMITank.HMITankCtrl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:HMITank     5      .��5	      (� .��5
   
   � .+�5      �� $	��150��6   $��80��6"   .+�5      �� -   5          ��Name$  RectangleFoot1��5      $��6��64   $��20��6>    �� Left$ 18��6J   
 �� Top$	 100��6[   $	��0.5��5      
���   � J� RenderTransformOrigin$ 0.5,0.5&�6=   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 60Q�6.   T� 5      5      ��5      �� 5       �� 
StartPoint$	 0,0&�6.    �� EndPoint$ 0.5,0&�6?    � SpreadMethod$ Reflect=�6P   .��5      �  � Color$
 Gray��6+   	 � Offset$	 0Q�68   � 5      $ White��6+   $	 1Q�69   5      5      �� 5      -   5        $  RectangleFoot2��5      $��6��64   $��20��6>   $ 55��6J   $	 100��6[   $	��0.5��5       
���   �$ 0.5,0.5&�6=   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%      $	 -60Q�6.   T� 5&      5'      ��5)      �� 5*      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5+      � $
 Gray��6+   $	 0Q�68   � 5,      $ White��6+   $	 1Q�69   5-      5/      �� 51      -   5        $  RectangleLeft��51      $��10��63   $��25��6>   $ 8��6J   $	 103��6Z   $	��0.5��52      
���   ���53      �� 54      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��55      � $
 Gray��6+   $	 0Q�68   � 56      $ White��6+   $	 1Q�69   57      59      �� 5;      -   5        $  RectangleRight��5;      $��10��64   $��25��6?   $ 63��6K   $	 103��6\   $	��0.5��5<      
���   ���5=      �� 5>      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5?      � $
 Gray��6+   $	 0Q�68   � 5@      $ White��6+   $	 1Q�69   5A      5C      �� 5E      -   5        $  FootLeft��5E      $��20��6.   $��8��69   $ 3��6D   $	 125��6T   $	��0.5��5F      
���   ���5G      �� 5H      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5I      � $
 Gray��6+   $	 0Q�68   � 5J      $ White��6+   $	 1Q�69   5K      5M      �� 5O      -   5        $  	FootRight��5O      $��20��6/   $��8��6:   $ 58��6E   $	 125��6V   $	��0.5��5P      
���   ���5Q      �� 5R      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5S      � $
 Gray��6+   $	 0Q�68   � 5T      $ White��6+   $	 1Q�69   5U      5W      F� 5Y      -   5        
 F�Name$
 	PathBody1��5Y      $��80��6*   $	��110��65   $ 0��6B   $ 0��6R    �� Stretch$
 Fill=�6a   $	��0.5��6p   
���   �������>{���ш>{@�� ш+aЕ ���'�f ���+eZP@�3F �P��p}0 ��Kg� ��kT� Ѱy��� QT�y�]��?I�?Q��\�j�  �>Q��?�j�  �>�\(��+ ь$��h	 ���E� ш~� �/$ �lO� ,�7 ��� jpM Ѧ�E lto �P �� �S��M�?��� �    @�� �    ����� �рJS ��N�3� �7o�`P� �2�Ѽ�hK��dE_pƤ�@��0��� ��ѐ"@h�ф�?@h�� ���=��<F� ��L�6(m��(y~����D����}��/L�
�P@p@gш�5h=E��"iX����z@��ш>{���	$ 0.496,0.484&�6p  ��5Z      
� 5[      .��5\      � $ 	#FFB4B4B4��6+   #	 � [�6=   � 5]      $ White��6+   � 5^      $ 	#FFA5A4A4��6+   #	 � 2�6=   5_      5a      F� 5d      -   5        $
 	PathBody2��5d      $��80��6*   $��4��65   $ 0��6@   $ 15��6P   $
 Fill=�6`   $	��0.5��6o   
���   �������>{���ш>{@�� ш+aЕ ���'�f ���+eZP@�3F �P��p}0 ��Kg� ��kT� Ѱy��� QT�y�]��?I�?Q��\�j�  �>Q��?�j�  �>�\(��+ ь$��h	 ���E� ш~� �/$ �lO� ,�7 ��� jpM Ѧ�E lto �P �� �S��M�?��� �    @�� �    ����� �рJS ��N�3� �7o�`P� �2�Ѽ�hK��dE_pƤ�@��0��� ��ѐ"@h�ф�?@h�� ���=��<F� ��L�6(m��(y~����D����}��/L�
�P@p@gш�5h=E��"iX����z@��ш>{���	��5e      �� 5f      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5g      � $
 Gray��6+   $	 0Q�68   � 5h      $ White��6+   $	 1Q�69   5i      5k      F� 5o      -	   5        $
 PathBody2_copy��5o      $��80��6/   $��4��6:   $ 0��6E   $ 94��6U   $
 Fill=�6e   $	��0.5��6t   
���   �������>{���ш>{@�� ш+aЕ ���'�f ���+eZP@�3F �P��p}0 ��Kg� ��kT� Ѱy��� QT�y�]��?I�?Q��\�j�  �>Q��?�j�  �>�\(��+ ь$��h	 ���E� ш~� �/$ �lO� ,�7 ��� jpM Ѧ�E lto �P �� �S��M�?��� �    @�� �    ����� �рJS ��N�3� �7o�`P� �2�Ѽ�hK��dE_pƤ�@��0��� ��ѐ"@h�ф�?@h�� ���=��<F� ��L�6(m��(y~����D����}��/L�
�P@p@gш�5h=E��"iX����z@��ш>{���	��5p      �� 5q      $	 0,0&�6.   $ 0.5,0&�6?   $ Reflect=�6P   .��5r      � $
 Gray��6+   $	 0Q�68   � 5s      $ White��6+   $	 1Q�69   5t      5v      � 5z      -
   5         �Name$ 
ProcessBar��5z      $��74��62   $ 33��6>   $ 20��6O   $��15��6_    � Orientation$ Vertical=�6j    � Value$ 50Q�6�   $ 
1.025,0.49&�6�   ���	#FF21A6A65{      5}      5      5�      5�      