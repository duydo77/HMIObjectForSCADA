   M S B A M L   `   `   `  ����K  GHMI_SevenSegment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HMI_SevenSegmentHMI_SevenSegment  5   	   !    HMI_SevenSegment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:HMI_SevenSegment     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  J� RenderTransformOrigin$ 0.538,0.471&�6   .+�5
   
   �� -   5         ��Name$ textBox��5
      $
��Left=�6#   $��22��6>   $��
56,208,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��1��6r   $	��Top=�6{   $��76��6�   �� 5   
   -   5         ��Name$ button��5      $	��Set��6!   $
��Left=�6/   $��
56,278,0,0q�6J   $	��Top=�6^   $��76��6v   6�   $   HMI_SevenSegment.SevenSegments  5   
   -   5          Name$ sevenSeg��5      $
��Left=�60   $��	24,16,0,0q�6K   $	��Top=�6^   $	��144��5      $	��134��6+      TurnOnColon .     ColonVisibility .    LedOffColor$ 	#FF003A12��5      	   
LedOnColor$	 	#FF08FF4B��66   
   BackgroundColor$
 	#FF535353��6M   	� 5   
   -   5         	�Name$ radioButton��5      $	��dot��5      $
��Left=�6$   $��
56,246,0,0q�6?   $	��Top=�6S   5      �� 5   
   -   5        $ textBox_int��5      $
��Left=�6'   $��23��6B   $��230,209,0,0q�6N   $
 Wrap=�6c   $��1��6w   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ 
button_int��5      $��Set Int��6%   $
��Left=�67   $��230,280,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $ textBox_float��5      $
��Left=�6)   $��23��6D   $��384,209,0,0q�6P   $
 Wrap=�6e   $��12.23��6y   $	��Top=�6�   $��76��6�   �� 5   
   -   5        $ button_float��5      $��	Set Float��6'   $
��Left=�6;   $��384,280,0,0q�6V   $	��Top=�6k   $��76��6�   6�   �� 5   
   -	   5        $ textBox_acc��5      $
��Left=�6'   $��23��6B   $��384,244,0,0q�6N   $
 Wrap=�6c   $��2��6w   $	��Top=�6�   $��76��6�   �� 5   
   -
   5         ��Name$ label1��5      $��Float��6    $
��Left=�60   $��341,208,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ label1_Copy��5      $	��Acc��6%   $
��Left=�63   $��348,243,0,0q�6N   $	��Top=�6c   �� 5   
   -   5        $ label1_Copy1��5      $	��Int��6&   $
��Left=�64   $��189,208,0,0q�6O   $	��Top=�6d   )   #HMI_SevenSegment.SevenSegmentsMulti  5   
   -   5          Name$ multi��5   #   $
��Left=�62   $��
208,46,0,0q�6M   $	��Top=�6a   $	��114��6y   $	��299��6�      NumberOfLed$ 5��6�      LedOffColor$ 	#FF00183A��6�      BackgroundColor$ 	#FF444444��6�      
LedOnColor$ 	#FF00EEE3��6�      VisibleAllColon . 6�   5      5      