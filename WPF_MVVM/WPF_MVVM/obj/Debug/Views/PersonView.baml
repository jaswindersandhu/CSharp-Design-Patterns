   M S B A M L   `   `   `  ����C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_MVVM.ViewsWPF_MVVM.Views  5          WPF_MVVM.Views.PersonView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WPF_MVVM.Views     5      .��5
      �   +� FocusedElement  6   ��  �� ElementName$ textBox��.+�5   
   �� -   5         ��Name$ textBox��5      $
��Left=�5      $��23��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6M   $	��200��6e   ��5      �� *CurrentName+ �� UpdateSourceTrigger$ PropertyChanged=�.��5   q    J� InputBindings 5      �� 5      
 �� Key$ Enter��6@    �� Command 6   �� *AddNameCommand+6@   .��5   %   5      �� 5   
   -   5         ��Name$ button��5      $	��Add��5      $
��Left=�6   $��	200,0,0,0q�6:   $	��Top=�6M   $	��100��6e   $��41��6q   ��5      �� *AddNameCommand+5   q   �� 5   
   -   5        $ button1��5      $��Delete��5      $
��Left=�6"   $��
200,41,0,0q�6=   $	��Top=�6Q   $	��100��6i   $��42��6u   ��5      �� *DeleteNameCommand+5   u   �� 5   
   -   5        $ button2��5      $��Replace��5      $
��Left=�6#   $��
200,82,0,0q�6>   $	��Top=�6R   $	��100��6j   $��41��6v   ��5      �� *ReplaceNameCommand+5   v   �� 5   
   -   5        	 ��Name$	 listBox��5      $
��Left=�5      $	��100��6-   $��0,23,0,0q�6:   $	��Top=�6L   $	��200��6d   ��5      �� *People+
 �� SelectedItem
 5      �� *SelectedPerson+��5      �� 5       .R�5!      �� ��6    �� *Name+5"      5$      5%      5'      