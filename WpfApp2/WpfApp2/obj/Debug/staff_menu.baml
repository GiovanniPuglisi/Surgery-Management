   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.staff_menu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  Staff_Screen��5   	    � Title$ Staff Screen��5   	   $��426.23��6   $	��800��6.    � 
ResizeMode$ NoResize=�6:   .��5	      � $��
0,0,5,10.5q�6    � Cursor$
 Hand��6    J� RenderTransformOrigin$ 0.093,0.641&�6-    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ btn_bookings��5      $��Bookings��6'   $
��Left=�6:   $	��Top=�6U   $	��170��6m   $
 Hand��6y   $ -0.007,-0.762&�6�   $��37��6�    �� 	ClickMode$ Press=�6�   $��
198,29,0,0q�6�   �� 5   
   -   5        $ btn_patients��5      $��Patients��6'   $
��Left=�6:   $��
368,29,0,0q�6U   $	��Top=�6i   $	��170��6�   $��37��6�   $ Press=�6�   $
 Hand��6�   �� 5   
   -   5        $ btn_home��5      $
��Home��6#   $
��Left=�62   $��	28,29,0,0q�6M   $	��Top=�6`   $	��170��6x   $��37��6�   6�   �� 5   
   -   5         ��Name$ 	SearchBox��5      $
��Left=�6%   $��24��6@   $��594,149,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6u   $	��110��6�   4  .System.Windows.Automation.AutomationProperties
   Name$
 Search��6�   $ IBeam��6�   .��6�   ��5      �� 5      .��5   "   5      �� 5   
   -   5         ��Name$ staff_on_duty_date��5      $��Staff on Duty (dd/mm/yy)��6,   $
��Left=�6O   $��	28,88,0,0q�6j   $	��Top=�6}   $��28��6�   $	��157��6�   �� 5   
   -   5        $ StaffSearchbt��5      $
��Left=�6(   $��725,149,0,0q�6C   $	��Top=�6X   $��24��6p   ��5      �� 5      .R�5      �� $��search_icon.png��6   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
28,116,0,0q�6@   $	��Top=�6T   $	��214��6l   $	��533��6y   �� 5   
   -	   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��594,133,0,0q�6B   $
��Wrap=�6W   $��Search for staff��6k   $	��Top=�6�   $ 0.928,1.725&�6�   (  "System.Windows.Controls.DatePicker  5    
   -
   5          Name$	 dp2��5       $
��Left=�6"   $��594,252,0,0q�6=   $	��Top=�6R   �� 5!   
   -   5        $��Button��5!      $
��Left=�6"   $��725,252,0,0q�6=   $	��Top=�6R   $��24��6j   ��5"      �� 5#      .R�5$      �� $��search_icon.png��6   5%      5'      �� 5(   
   -   5        $ bt_register_staff��5(      $��New employee��6,   $
��Left=�6C   $��
28,345,0,0q�6^   $	��Top=�6r   $	��110��6�   $��30��6�   6�   5)      5*      