   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	   "    WpfApplication1.Αρχική   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  Αρχική��5   	   $	��421��6   $	��527��6%   .��5	      � $��0,0,2,2.009q�6   ��5
   
   �� 5       �� ImageSource$B <brown-wooden-framed-blackboard-illustration-png-clip-art.png��6   .+�5   
   �� -   5         ��Name$ title��5      $6��0Ας μάθουμε την προπαίδεια ��6   $��50.092��6D   $��100.213,32.471,62.659,0q�6T   $	��Top=�6u    � Cursor$
 None��6�   $��Mistral)�6�   $��36(�6�   $
��Bold"�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6�   ���	#FFF7F1F1��6�   Z� 6
  �� 5   
   -   5        $ welcome��5      $�� ��6!   $��152.872,87.563,10,0q�6,   $
 None��6I   $��Mistral)�6W   $��22(�6l   ���	#FFF7F1F1$ Fixed=�6�   $��Disabled=�6�   $��68.092��6�   $	��Top=�6  ��6z   Z� 6  G� 5   
   -   5         G�Name$ passwordBox��5      $��22.75��6+   $��167.341,0,265.659,107.554q�6:   $��Bottom=�6]   $��Disabled=�6�   ���	#FFF7F1F1���	#FFF7F1F1 J� RenderTransformOrigin$ 0.571,-2.402&�6�   ��6x   Z� 6�   �� 5   
   -   5        $ label2��5      $��Είσοδος��6    $%��167.341,160.655,265.659,180.874q�62   $��24(�6[   $
 None��6i   
�������$��2q�6�      TextFormattingMode$ Display=�6�   $ Fixed=�6�   $��Mistral)�6�   �� 5   
   -   5         ��Name$ UsernameBox��5      $��22.75��6'   $��167.341,0,265.659,141.859q�66   	 �� TextWrapping$
	 Wrap=�6Y   $��Username��6m   $��Bottom=�6}   ���	#FFF7F1F1���	#FFF7F1F1.��6�   ��5      �� 5      
 �� Color$
 White��6"    �� Opacity$ 0Q�60   .��5   "   5      �� 5   
   -   5         ��Name$ log_in��5      $��Σύνδεση��6!   $$��167.341,300.716,265.659,56.218q�63   $��2q�6[   ���	#FFF7F1F1���	#FFF7F1F1$��Mistral)�6�   $
��Bold"�6�   $��16(�6�   $
 Hand��6�   ��5      �� 5      $
 	#FFDDDDDD��6"   $ 0Q�64   5      G� 5   
   -   5        $ passwordBoxR��5      $��22.75��6,   $��370.341,0,62.659,141.859q�6;   $��Bottom=�6]   $��Disabled=�6�   ���	#FFF7F1F1���	#FFF7F1F1$ 0.571,-2.402&�6�   ��6x   Z� 6�   �� 5   
   -   5        $ label3��5      $��Εγγραφή��6    $$��317.341,165.655,95.659,164.609q�62   $��24(�6Z   $
 None��6h   
�������$��2q�6�   $ Display=�6�   $ Fixed=�6�   $��Mistral)�6�   �� 5   
   -	   5        $ UsernameBoxR��5      $��22.75��6(   $��281.341,0,151.659,141.859q�67   $
	 Wrap=�6Z   $��Username��6n   $��Bottom=�6~   ���	#FFF7F1F1���	#FFF7F1F1.��6�   ��5      �� 5      $
 White��6"   $ 0Q�60   .��5    "   5!      �� 5"   
   -
   5        $ sign_up��5"      $��Εγγραφή��6"   $$��317.341,311.554,115.659,45.379q�64   $��2q�6\   ���	#FFF7F1F1���	#FFF7F1F1$��Mistral)�6�   $
��Bold"�6�   $��16(�6�   $
 Hand��6�   ��5#      �� 5$      $
 	#FFDDDDDD��6"   $ 0Q�64   5&      �� 5'   
   -   5        $ emailR��5'      $��22.75��6"   $��281.341,0,151.659,107.554q�61   $
	 Wrap=�6T   $��Email��6h   $��Bottom=�6u   ���	#FFF7F1F1���	#FFF7F1F1.��6�   ��5(      �� 5)      $
 White��6"   $ 0Q�60   .��5*   "   5+      	� 5,   
   -   5         	�Name$ student��5,      $��Μαθητής��6'   $��Right=�69   $��26.117��6U   $��0,0,151.659,73.108q�6e   $��Bottom=�6�   $��84��6�   
�������$��Mistral)�6�   $��16(�6�   ��6�   Z� 6�   	� 5-   
   -   5        $ teacher��5-      $��Καθηγητής��6'   $��Right=�6;   $��26.117��6W   $��0,0,62.659,73.108q�6g   $��Bottom=�6�   $��84��6�   
�������$��16(�6�   $��Mistral)�6�   ��6�   Z� 6�   �� 5.   
   -   5        $ label��5.      $	��2x5��6   $
��Left=�6-   $��54.547,155.642,0,187.377q�6H   $��60.53��6j   $��Mistral)�6x   $��24(�6�   $ 0.5,0.5&�6�   
�������$
 None��6�   z�5/      V� 50      .~�51      �� �� 52      �� 53       �� Angle$ -53.406Q�6&   T� 54      55      57      �� 58   
   -   5        $ 
label_Copy��58      $	��6x3��6$   $
��Left=�62   $��62.547,0,0,117.377q�6M   $��60.53��6i   $��Mistral)�6w   $��24(�6�   $ 0.5,0.5&�6�   
�������$
 None��6�   $��44.972��6�   $��Bottom=�6�   z�59      V� 5:      .~�5;      �� �� 5<      �� 5=      $ -0.523Q�6&   T� 5>      5?      5A      �� 5B   
   -   5        $ label_Copy1��5B      $	��9x9��6%   $
��Left=�63   $��70.547,0,0,57.377q�6N   $��60.53��6i   $��Mistral)�6w   $��24(�6�   $ 0.5,0.5&�6�   
�������$
 None��6�   $��44.972��6�   $��Bottom=�6�   z�5C      V� 5D      .~�5E      �� �� 5F      �� 5G      $ 28.024Q�6&   T� 5H      5I      5K      �� 5L   
   -   5        $ label_Copy2��5L      $
��10x1��6%   $
��Left=�64   $��52.547,107.642,0,0q�6O   $��60.53��6k   $��Mistral)�6y   $��24(�6�   $ 0.5,0.5&�6�   
�������$
 None��6�   $��44.972��6�   $	��Top=�6�   z�5M      V� 5N      .~�5O      �� �� 5P      �� 5Q      $ 362.25Q�6&   T� 5R      5S      5U      �� 5V   
   -   5        $ fullname��5V      $��22.75��6$   $��370.341,0,62.659,107.554q�63   $
	 Wrap=�6U   $��Fullname��6i   $��Bottom=�6y   ���	#FFF7F1F1���	#FFF7F1F1.��6�   ��5W      �� 5X      $
 White��6"   $ 0Q�60   .��5Y   "   5Z      5\      5]      