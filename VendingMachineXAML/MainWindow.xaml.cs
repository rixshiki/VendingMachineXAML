using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using VendingMachineXAML.ViewModels;

namespace VendingMachineXAML
{
    public partial class MainWindow : Window
    {
        private MachineViewModel _machine = new MachineViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _machine;
        }

        // Customer purchase item
        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            _machine.Purchase(button.DataContext);
        }

        // Customer insert money
        private void Insert20_Click(object sender, RoutedEventArgs e) { _machine.Insert(20); }
        private void Insert50_Click(object sender, RoutedEventArgs e) { _machine.Insert(50); }
        private void Insert100_Click(object sender, RoutedEventArgs e) { _machine.Insert(100); }
        private void Insert500_Click(object sender, RoutedEventArgs e) { _machine.Insert(500); }
        private void Insert1000_Click(object sender, RoutedEventArgs e) { _machine.Insert(1000); }

        // Customer collect change
        // Show return each cash 20, 50, 100, 500, 1000
        private void ReturnChangeButton_Click(object sender, RoutedEventArgs e)
        {
            int change = _machine.Payment.Inserted;
            string changeString = "\n";
            foreach(int i in new List<int>(){ 1000, 500, 100, 50, 20 })
            {
                if (change >= i)
                {
                    changeString += "x" +(change / i)+ " " +i+ "฿\n";
                    change %= i;
                }
            }
            _machine.Payment.ReturnChange();
            MessageBox.Show("RETURN: " +changeString);
        }

        // VENDING MANAGER refill all of items
        private void RefillButton_Click(object sender, RoutedEventArgs e)
        {
            _machine.Refill();
        }
        // VENDING MANAGER clear all of items
        private void EmptyButton_Click(object sender, RoutedEventArgs e)
        {
            _machine.Empty();
        }
        // VENDING MANAGER collect all payment
        private void CollectPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            int last_collect = _machine.Payment.MachineTotal;
            _machine.Payment.CollectPayment();
            MessageBox.Show("COLLECT: " +last_collect+ " ฿");
        }

        // Customer collect all item
        private void CollectItemButton_Click(object sender, RoutedEventArgs e)
        {
            string bills = _machine.ShowBills;
            _machine.ClearBill();
            if(bills != "")
            {
                MessageBox.Show("PICK:\n"+bills);
            }
        }
    }
}
