   M S B A M L   `   `   `  ����A  =Pebble, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PebblePebble  5   	       Pebble.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *	MyControlclr-namespace:Pebble     5   	   -   5          � Title$  
MainWindow��5   	   $	��720��6   $
��1300��6)    � 	Resources 5         ImageStyle1 �� 
TargetType �� Property �� Value��%[   &	        �� 5   
   " ��6$   .�5      ��  � ��$ LeftToRight=�6.   5	      5
      .��5      � $��	0,0,2,-21q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6%   $��0,0,0,27q�6<   .+�5      �� $ 
Horizontal=�6   $��48��62   $��0,0,0,0q�6>   .+�5      �� $��0 8 0 0q�6   $��5q�6,   $��Center=�67   $��Search��6R    �� TextAlignment$ Justify=�6`   $��20(�6x   $	��242��6�   �� 5      $��59��6   $V��PE:\Resources\ic_search_black_24dp\android\drawable-hdpi\ic_search_black_24dp.png��6$   5      �� 5      $��5,15,0,0q�6   $	��610��6+   .@�5      �� $��Surah��6   $��22(�6)   ��. $��	45 0 45 0q�6\   .��5,      �� -   5         ��Name$ ScrollViewer��5,   0   $	��580��6#   .��5-      �� -   5        	 ��Name$	 ItemsControl��5-   '   ��5.      �� 5/   "   .R�50   &      Pebble.SurahListItem     Pebble.SurahListItem
   MouseLeftButtonDown'
 #SurahListItem_MouseLeftButtonDown_16?   51   #   53      55      56      �� 59      $	��Juz��6   $��22(�6'   $��	45 0 75 0q�65   5;      5<      5>      �� 5?   
   -   5        $	��Top=�5?   .   $n��hC:\Users\Yousha Arif\Documents\Visual Studio 2012\Projects\Pebble\Pebble\Images\QuranEMajeedTestPic1.gif��6F   $
��None=�6�   $��2��6�   $��
306,0,16,0q�6�   5A      5B      