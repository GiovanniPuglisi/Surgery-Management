   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   !    WpfApp2.Individual_bookings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  individual_booking��5   	    � Title$ Individual Bookings��5   	   $	��350��6%   $	��520��62    � 
ResizeMode$ NoResize=�6>   .��5	      � .+�5
   
   �� -   5         ��Name$ bt_cancel_booking��5
      $��Cancel Booking��6,   $
��Left=�6E   $��300,108,0,0q�6`   $	��Top=�6u   $	��179��6�   $��50��6�    � Cursor$
 Hand��6�   6�   �� 5   
   -   5        $ bt_save_changes��5      $��Save Changes��6*   $
��Left=�6A   $��300,191,0,0q�6\   $	��Top=�6q   $	��179��6�   $��50��6�   6�   �� 5   
   -   5         ��Name$ booking_details_view��5      $��Booking Details��6.   $
��Left=�6H   $��	25,28,0,0q�6c   $	��Top=�6v   $��29��6�   $	��113��6�   $
��Bold"�6�   �� 5   
   -   5        $ lb_patient_id��5      $��Patient ID:��6'   $
��Left=�6=   $��	25,81,0,0q�6X   $	��Top=�6k   �� 5   
   -   5        $ lb_patient_name��5      $��Name:��6)   $
��Left=�69   $��
44,104,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ lb_date��5      $��Date:��6!   $
��Left=�61   $��
51,126,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ lb_time��5      $��Time:��6!   $
��Left=�61   $��
50,149,0,0q�6L   $	��Top=�6`   �� 5   
   -	   5        $ 	lb_doctor��5      $��Doctor:��6#   $
��Left=�65   $��
39,172,0,0q�6P   $	��Top=�6d   �� 5   
   -
   5        $ lb_room��5      $��Room:��6!   $
��Left=�61   $��
45,196,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ lb_description��5      $��Description:��6(   $
��Left=�6?   $��
16,221,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5         ��Name$ tb_patientid��5      $
��Left=�6(   $��23��6C   $��	94,85,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $��
Patient ID��6v   $	��Top=�6�   $	��180��6�   .��6�   5      �� 5   
   -   5        $ tb_name��5      $
��Left=�6#   $��23��6>   $��
94,108,0,0q�6J   $
 Wrap=�6^   $
��Name��6r   $	��Top=�6~   $	��180��6�   .��6�   5      �� 5   
   -   5        $ tb_date��5      $
��Left=�6#   $��23��6>   $��
94,131,0,0q�6J   $
 Wrap=�6^   $
��Date��6r   $	��Top=�6~   $	��180��6�   �� 5   
   -   5        $ tb_time��5      $
��Left=�6#   $��23��6>   $��
94,154,0,0q�6J   $
 Wrap=�6^   $
��Time��6r   $	��Top=�6~   $	��180��6�   �� 5   
   -   5        $ 	tb_doctor��5      $
��Left=�6%   $��23��6@   $��
94,177,0,0q�6L   $
 Wrap=�6`   $��Doctor��6t   $	��Top=�6�   $	��180��6�   �� 5   
   -   5        $ tb_room��5      $
��Left=�6#   $��23��6>   $��
94,200,0,0q�6J   $
 Wrap=�6^   $
��Room��6r   $	��Top=�6~   $	��180��6�   �� 5   
   -   5        $ tb_description��5      $
��Left=�6*   $��55��6E   $��
94,221,0,0q�6Q   $
 Wrap=�6e   $��Description��6y   $	��Top=�6�   $	��180��6�   �� 5   
   -   5        $ lb_patient_id_Copy��5      $��
Booking ID��6,   $
��Left=�6A   $��	25,62,0,0q�6\   $	��Top=�6o   �� 5   
   -   5         ��Name$ tb_bookingid��5      $
��Left=�6*   $��	94,69,0,0q�6E   $
��Wrap=�6X   $��	TextBlock��6l   $	��Top=�6}   $	��180��6�   5!      5"      