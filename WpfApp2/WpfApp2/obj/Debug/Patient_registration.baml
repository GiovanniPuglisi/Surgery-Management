   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   "    WpfApp2.Patient_registration   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  Patient_registration1��5   	   $	��429��5      $	��397��6'    � Title$ Patient Registeration��63    � 
ResizeMode$ NoResize=�6Q   .��5      � .+�5	   
   �� -   5         ��Name$ 	textBlock��5	      $
��Left=�6'   $��	10,32,0,0q�6B   $
��Wrap=�6U   $
��Name��6i   $	��Top=�6u   �� 5
   
   -   5         ��Name$ tb_name��5
      $
��Left=�6#   $��23��6>   $��	10,48,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 1.925Q�6$   �� 5      T� 5       T� X$ -0.387Q�6)   5      .��5   '   5      �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��	10,86,0,0q�6C   $
��Wrap=�6V   $��Surname��6j   $	��Top=�6y   �� 5   
   -   5        $ 
tb_surname��5      $
��Left=�6&   $��23��6A   $��
10,102,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��
10,139,0,0q�6C   $
��Wrap=�6W   $��Date of birth��6k   $	��Top=�6�   $��84��6�   $ 0.5,0.5&�6�   �� 5   
   -   5        $ tb_dob��5      $
��Left=�6"   $��23��6=   $��
10,155,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   6�   �� 5   
   -   5        $ 
textBlock3��5      $
��Left=�6(   $��
10,195,0,0q�6C   $
��Wrap=�6W   $��Address��6k   $	��Top=�6z   �� 5   
   -	   5        $ 	tb_street��5      $
��Left=�6%   $��23��6@   $��
10,211,0,0q�6L   $
 Wrap=�6`   $��(Street)��6t   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -
   5        $ tb_city��5      $
��Left=�6#   $��23��6>   $��
10,239,0,0q�6J   $
 Wrap=�6^   $��(City)��6r   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ tb_postcode��5      $
��Left=�6'   $��23��6B   $��
10,267,0,0q�6N   $
 Wrap=�6b   $��
(Postcode)��6v   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ tb_phone��5      $
��Left=�6$   $��23��6?   $��
256,48,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ tb_emergency_phone��5      $
��Left=�6.   $��23��6I   $��
256,76,0,0q�6U   $
 Wrap=�6i   $��(Emergency contact)��6}   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ 
textBlock4��5      $
��Left=�6(   $��256,109,0,0q�6C   $
��Wrap=�6X   $��E-mail��6l   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ tb_email��5      $
��Left=�6$   $��23��6?   $��256,125,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5    
   -   5        $ 
textBlock5��5       $
��Left=�6(   $��
256,32,0,0q�6C   $
��Wrap=�6W   $��Phone number��6k   $	��Top=�6   $	��120��6�   �� 5!   
   -   5        	 ��Name$	 
Registerbt��5!      $��Register��6%   $
��Left=�68   $��260,275,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5"   
   -   5        $ 
textBlock6��5"      $
��Left=�6(   $
��Wrap=�6C   $��Register new patient��6W   $	��Top=�6s   $	��135��6�   $��10,0,0,0q�6�   5$      5%      