   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.booking_screen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  bookings_screen��5   	    � Title$ Bookings��5   	   $	��400��6   $��800         ��6'    � 
ResizeMode$ NoResize=�5	      .��5
      � .+�5   
   �� -   5         ��Name$ bt_home��5      $
��Home��6"   $
��Left=�61   $	��Top=�6L   $	��170��6d   $��37��6p    � Cursor$
 Hand��6|   $��	21,14,0,0q�6�   �� 5   
   -   5        $ bt_patients��5      $��Patients��6&   $
��Left=�69   $��
191,14,0,0q�6T   $	��Top=�6h   $	��170��6�   $
 Hand��6�   $��37��6�   6�   �� 5   
   -   5        $ bt_staff��5      $��Staff��6#   $
��Left=�63   $��
361,14,0,0q�6N   $	��Top=�6b   $	��170��6z   $��37��6�   6�   �� 5   
   -   5        $ bt_new_booking��5      $��New Booking��6)   $
��Left=�6?   $��
23,327,0,0q�6Z   $	��Top=�6n   $	��110��6�   $��24��6�   6�   �� 5   
   -   5         ��Name$ booking_search��5      $
��Left=�6*   $��24��6E   $��622,120,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��110��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ bookingsGrid��5         AutoGenerateColumns . $
��Left=�6D   $��	22,90,0,0q�6_   $	��Top=�6r   $	��216��6�   $	��575��6�   �� 5   
   -   5        $ bTsearch��5      $��Search��6#   $
��Left=�64   $��744,120,0,0q�6O   $	��Top=�6d   $��24��6|   ��5      �� 5      .R�5      �� $��search_icon.png��6   5      5      �� 5   
   -	   5        	 ��Name$	 label��5      $��Today's Bookings��6   $
��Left=�6:   $��	22,53,0,0q�6U   $	��Top=�6h   $��13.333(�6�   �� 5   
   -
   5        
 ��Name$
 	textBlock��5      $
��Left=�6'   $��
626,86,0,0q�6B   $
��Wrap=�6V   $��Search by ID��6j   $	��Top=�6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$	 dp1��5      $
��Left=�6"   $��622,236,0,0q�6=   $	��Top=�6R      IsTodayHighlighted . 6j   �� 5   
   -   5        $ bTsearchDate��5      $��Button��6'   $
��Left=�68   $��744,236,0,0q�6S   $	��Top=�6h   $��24��6�   ��5      �� 5      .R�5      �� $��search_icon.png��6   5      5!      �� 5"   
   -   5        $
 textBlock_Copy��5"      $
��Left=�6,   $��622,199,0,0q�6G   $
��Wrap=�6\   $ ��Show bookings on this date��6p   $	��Top=�6�   $	��156��6�   5#      5$      