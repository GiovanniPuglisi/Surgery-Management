   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.staff_individual   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  staff_details��5   	    � Title$ Staff Details��5   	   $��379.25��6   $��520.75��6/    � 
ResizeMode$ NoResize=�6>   .��5	      �  � Cursor$
 Hand��6   .+�5
   
   �� -   5         ��Name$ staff_shift_week��5
      $��Shifts��6*   $
��Left=�6;   $��
33,151,0,0q�6V   $	��Top=�6j   $��25��6�   $	��122��6�   �� 5   
   -   5        $ lb_staff_id��5      $��Staff ID��6%   $
��Left=�68   $��	30,44,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lb_staff_name��5      $
��Name��6'   $
��Left=�66   $��	37,75,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5         ��Name$ tb_staff_name��5      $
��Left=�6)   $��23��6D   $��	84,78,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ 
lb_address��5      $��Address��6$   $
��Left=�66   $��
209,44,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ 
tb_address��5      $
��Left=�6&   $��23��6A   $��
262,51,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��210��6�   �� 5   
   -   5        $ tb_contact_details��5      $
��Left=�6.   $��23��6I   $��
84,109,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $ lb_contact_details��5      $��Contacts��6,   $
��Left=�6?   $��
22,106,0,0q�6Z   $	��Top=�6n   �� 5   
   -
   5        $ lb_dob��5      $	��DOB��6    $
��Left=�6.   $��
224,78,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ tb_dob��5      $
��Left=�6"   $��23��6=   $��
267,81,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ lb_role��5      $
��Role��6!   $
��Left=�60   $��224,114,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ tb_role��5      $
��Left=�6#   $��23��6>   $��267,114,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5         ��Name$ tb_staff_id��5      $
��Left=�6)   $��	84,49,0,0q�6D   $
��Wrap=�6W   $	��Top=�6k   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
37,181,0,0q�6@   $	��Top=�6T   $	��152��6l   $	��133��6y     5   
   -   5        $ bookingsGrid��5      $
��Left=�6)   $��170,181,0,0q�6D   $	��Top=�6Y   $	��152��6q   $��88��6~   �� 5   
   -   5        $ 	textBlock��5      $
��Left=�6'   $��170,156,0,0q�6B   $
��Wrap=�6W   $��Bookings��6k   $	��Top=�6{   �� 5   
   -   5        	 ��Name$	 bt_new_shift��5      $��	New shift��6'   $
��Left=�6;   $��397,313,0,0q�6V   $	��Top=�6k   $��75��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        
  Name$	
 dp1��5      $
��Left=�6"   $��311,181,0,0q�6=   $	��Top=�6R   �� 5   
   -   5        $	 bt_search_dp��5      $��Button��6'   $
��Left=�68   $��442,181,0,0q�6S   $	��Top=�6h   $��24��6�   ��5      �� 5      .R�5      �� $��search_icon.PNG��6   5       5"      5$      5%      