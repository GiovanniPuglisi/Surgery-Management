   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.Patients   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Patients��5   	   $	��400��6   $	��800��6'    � 
ResizeMode$ NoResize=�63   .��5	      � .+�5
   
   �� -   5         ��Name$ bt_home��5
      $
��Home��6"   $
��Left=�61   $	��Top=�6L   $	��170��6d   $��37��6p    � Cursor$
 Hand��6|   $��	31,20,0,0q�6�   �� 5   
   -   5        $ 
bt_booking��5      $��Bookings��6%   $
��Left=�68   $��
201,20,0,0q�6S   $	��Top=�6g   $	��170��6   $��37��6�   $
 Hand��6�   6�   �� 5   
   -   5        $ bt_staff��5      $��Staff��6#   $
��Left=�63   $��
371,20,0,0q�6N   $	��Top=�6b   $	��170��6z   $��37��6�   $
 Hand��6�   6�   �� 5   
   -   5        $ bt_register_patient��5      $��Register Patient��6.   $
��Left=�6I   $��
28,320,0,0q�6d   $	��Top=�6x   $	��110��6�   $��30��6�   $
 Hand��6�   6�   �� 5   
   -   5         ��Name$ 	SearchBox��5      $
��Left=�6%   $��24��6@   $��575,195,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��110��6�   �� 5   
   -   5         ��Name$ todays_patient��5      $��Today's Patient��6(   $
��Left=�6B   $��	28,70,0,0q�6]   $	��Top=�6p   �� 5   
   -   5        $
��Left=�5      $��715,195,0,0q�6,   $	��Top=�6A   $��24��6Y   ��5      �� 5      .R�5      �� $��search_icon.png��6   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
28,114,0,0q�6@   $	��Top=�6T   $	��191��6l   $	��523��6y   �� 5   
   -	   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��575,179,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   �� 6�   $�Search for patient��6�   �� 6�   $�s��6�   6�   5      5      