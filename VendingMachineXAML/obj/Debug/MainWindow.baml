   M S B A M L   `   `   `  ����M  IVendingMachineXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VendingMachineXAMLVendingMachineXAML  5   	   M+clr-namespace:VendingMachineXAML.ViewModelsVendingMachineXAML.ViewModels  68   #    VendingMachineXAML.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:VendingMachineXAML     5   	   B
viewmodels+clr-namespace:VendingMachineXAML.ViewModels     68     � Title$  VENDING MACHINE��5   	   $	��600��6!   $	��500��6.   .��5	      � 
����=H� � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��5��6%   .+�5      ��    	TitleText#��[  6   DRINK MACHINE6J   5      �� 5    
   -   5         ��Name$ ItemList��5    8     VendingList#��[ 6   $��1��6h   $��3��6u   $��5��6�   ��6J   �� *Items+��5!      �� 5"      .R�5#      ]� .+�5$      �� -   5          VendingButton#��[ 5$   !   $
��Left=�6H   $
��PICK��6�    � DataContext 6^   �� 6�   �� 5%      $��Right=�6%   .+�5&      ��   NameItem#��[ 6(   ��6J   �� *Information.Name+�� 5'        
DetailItem#��[ 6(   ��6L   �� *ShowItemPrice+�� 5(      #��[ 6(   ��6L   �� *ShowItemQuantity+5)      5*      5+      5-      �� 5/   
     CashDisplay#��[ 6   $��1��6:   $��3��6G   $��2��6W   .+�50      ��   CashText#��[ 6   ��6:   �� *Payment.Inserted+51      �� 53   
   $��2��6   $��3��6"   $��2��62   .+�54      �� $��Center=�6   
�������$��Insert Money��6H   � 55       � Orientation$ 
Horizontal=�6   $��Center=�61   $��0,20,0,0q�6N   .+�56      �� -   5          
CashButton#��[ 56      
������$��20฿��6U   6c   �� 57      -   5        #��[ 57      
����ح�$��50฿��6T   6b   �� 58      -   5        #��[ 58      
�������$��100฿��6U   6d   �� 59      -   5        #��[ 59      
������$��500฿��6Q   6`   �� 5:      -   5        #��[ 5:      
�������$��1000฿��6T   6d   5;      5<      �� 5>   
   -   5          ChangeButton#��[ 5>      $��3��67   $��3��6D   $��2��6T   $��Return Change��6h   6�   �� 5@   
    	 ManagerBlock#��[	 6   $��4��6;   $��3��6H   $��2��6X   $��2��6i   .+�5A      �� $��Center=�6   $��14(�65   $��MANAGE MACHINE��6C   �� 5B      -	   5         ��Name$ RefillButton��5B       
 ManagerButton#��[
 6+   $��Refill Supply��6R   6j   �� 5C      -
   5        $ EmptyButton��5C      #��[
 6*   $��Empty Supply��6Q   6h   �� 5D      -   5        #��[
 5D      ��6<   �� *Payment.ShowCollectPayment+6k   5E      �� 5G   
   -   5          CollectItem#��[ 5G      $��6��66   $��5��6C   $��2��6W   ��6�   �� *	ShowBills+6�   5H      5I      