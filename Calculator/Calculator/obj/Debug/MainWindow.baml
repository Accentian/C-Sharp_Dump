   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��575��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��263* �6   �� 5      .+�5   
   �� -   5         ��Name$ 
txtResults��5      $
��Left=�6&   $��34��6A   $��	10,19,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��545��6�   {�.  $��0��6�   $��22(�6�   �� 5   
   -   5         ��Name$
 btn1��5      $��1��6   $
��Left=�6+   $��	77,80,0,0q�6F   $	��Top=�6Y   $��78��6q   $��78��6|   $��22(�6�   �� 5   
   -   5        $
 btn2��5      $��2��6   $
��Left=�6+   $��
159,80,0,0q�6F   $	��Top=�6Z   $��79��6r   $��78��6}   $��22(�6�   �� 5   
   -   5        $
 btn3��5      $��3��6   $
��Left=�6+   $��
243,80,0,0q�6F   $	��Top=�6Z   $��77��6r   $��78��6}   $��22(�6�   �� 5   
   -   5        $
 btn4��5      $��4��6   $
��Left=�6+   $��
77,162,0,0q�6F   $	��Top=�6Z   $��78��6r   $��79��6}   $��22(�6�   �� 5   
   -   5        $
 btn5��5      $��5��6   $
��Left=�6+   $��159,162,0,0q�6F   $	��Top=�6[   $��79��6s   $��79��6~   $��22(�6�   �� 5   
   -   5        $
 btn6��5      $��6��6   $
��Left=�6+   $��243,162,0,0q�6F   $	��Top=�6[   $��77��6s   $��79��6~   $��22(�6�   �� 5   
   -   5        $
 btn7��5      $��7��6   $
��Left=�6+   $��
77,246,0,0q�6F   $	��Top=�6Z   $��78��6r   $��77��6}   $��22(�6�   �� 5   
   -	   5        $
 btn8��5      $��8��6   $
��Left=�6+   $��159,246,0,0q�6F   $	��Top=�6[   $��79��6s   $��77��6~   $��22(�6�   �� 5   
   -
   5        $
 btn9��5      $��9��6   $
��Left=�6+   $��243,246,0,0q�6F   $	��Top=�6[   $��77��6s   $��77��6~   $��22(�6�   �� 5   
   -   5        $
 btn0��5      $��0��6   $
��Left=�6+   $��
77,328,0,0q�6F   $	��Top=�6Z   $	��161��6r   $��77��6~   $��22(�6�   �� 5   
   -   5        $ btnClear��5      $��Clear��6#   $
��Left=�63   $��371,328,0,0q�6N   $	��Top=�6c   $	��159��6{   $��77��6�   $��22(�6�   �� 5   
   -   5        $ btnPlus��5      $��+��6"   $
��Left=�6.   $��
451,80,0,0q�6I   $	��Top=�6]   $��79��6u   $��77��6�   $��22(�6�   6�   �� 5   
   -   5        $ btnMinus��5      $��-��6#   $
��Left=�6/   $��451,164,0,0q�6J   $	��Top=�6_   $��79��6w   $��77��6�   $��22(�6�   6�   �� 5   
   -   5        $ btnEqual��5      $��=��6#   $
��Left=�6/   $��371,246,0,0q�6J   $	��Top=�6_   $	��159��6w   $��77��6�   $��22(�6�   6�   5      5      