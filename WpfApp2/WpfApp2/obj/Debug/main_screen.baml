   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.main_screen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$
  Home��5   	   $	��400��6   $	��800��6#    � 
ResizeMode$ NoResize=�6/   .��5	      � .+�5
   
   �� -   5         ��Name$ bt_bookings��5
      $��Booking��6&   $
��Left=�68   $	��Top=�6S   $	��170��6k    � Cursor$
 Hand��6w   $��37��6�   $��	26,23,0,0q�6�   �� 5   
   -   5        $ bt_patients��5      $��Patients��6&   $
��Left=�69   $��
196,23,0,0q�6T   $	��Top=�6h   $	��170��6�   $
 Hand��6�   $��37��6�   6�   �� 5   
   -   5        $ bt_staff��5      $��Staff��6#   $
��Left=�63   $��
366,23,0,0q�6N   $	��Top=�6b   $	��170��6z   $��37��6�   $
 Hand��6�   6�   �� 5   
   -   5        $ bt_register_patient��5      $��Register Patient��6.   $
��Left=�6I   $��152,305,0,0q�6d   $	��Top=�6y   $	��100��6�   $��50��6�   6�   �� 5   
   -   5        $ bt_new_booking��5      $��New Booking��6)   $
��Left=�6?   $��
28,305,0,0q�6Z   $	��Top=�6n   $	��100��6�   $
 Hand��6�   $��50��6�   6�   �� 5   
   -   5         ��Name$ search_patient��5      $
��Left=�6*   $��24��6E   $��580,233,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��97��6�   $ IBeam��6�   �� 5   
   -   5        $ search_booking��5      $
��Left=�6*   $��24��6E   $��580,145,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��97��6�   $ IBeam��6�   �� 5   
   -   5         ��Name$ todays_patient��5      $��Todays's Patient��6(   $
��Left=�6C   $��	25,64,0,0q�6^   $	��Top=�6q   $��27��6�   $��99��6�   �� 5   
   -	   5        $ bTsearch��5      $��Search��6#   $
��Left=�64   $��694,141,0,0q�6O   $	��Top=�6d   $��24��6|   ��5      �� 5      .R�5      �� $��search_icon.PNG��6   5      5      �� 5   
   -
   5        $ 	bTsearch1��5      $
��Left=�6$   $��694,229,0,0q�6?   $	��Top=�6T   $��24��6l   ��5      �� 5      .R�5      �� $��search_icon.PNG��6   5      5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dataGrid��5       $
��Left=�6%   $��	25,96,0,0q�6@   $	��Top=�6S   $	��195��6k   $	��532��6x   �� 5!   
   -   5         ��Name$ 	textBlock��5!      $
��Left=�6'   $��580,129,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��97��6�   �� 6�   $�Search booking��6�   �� 6�   $	� id��6�   6�   �� 5"   
   -   5        $ textBlock_Copy��5"      $
��Left=�6,   $��580,212,0,0q�6G   $
��Wrap=�6\   $	��Top=�6p   $��97��6�   �� 6�   $�Search patient��6�   �� 6�   $	� id��6�   6�   5$      5%      