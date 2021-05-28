using System;

namespace VendingMachineXAML.ViewModels
{
    public class PaymentViewModel : ObserverObject
    {
        private int _inserted;
        private int _total;
        private int _machineTotal;

        public int Inserted
        {
            get => _inserted;
            set
            {
                _inserted = value;
                OnPropertyChanged("Inserted");
            }
        }

        public int Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public int MachineTotal
        {
            get => _machineTotal;
            set
            {
                _machineTotal = value;
                OnPropertyChanged("MachineTotal");
                OnPropertyChanged("ShowCollectPayment");
            }
        }
        public string ShowCollectPayment
        {
            get => "MACHINE COLLECT: " + _machineTotal + " ฿";
        }

        public void Insert(int money)
        {
            Inserted += money;
        }
        public void SelectPrice(int price)
        {
            Total = price;
        }
        public bool Confirm()
        {
            if(Inserted >= Total) return true;
            return false;
        }
        public void Paid()
        {
            MachineTotal += Total;
            Inserted -= Total;
            Total = 0;
        }
        public void ReturnChange()
        {
            Inserted = 0;
            Total = 0;
        }
        public void CollectPayment()
        {
            Console.WriteLine("Collected payment: ฿{0}", MachineTotal);
            MachineTotal = 0;
        }
    }
}
