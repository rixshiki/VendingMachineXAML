using System;
using System.Collections.ObjectModel;

namespace VendingMachineXAML.ViewModels
{
    public class MachineViewModel : ObserverObject
    {
        public ObservableCollection<ProductViewModel> Items { get; set; }
        public PaymentViewModel Payment { get; set; }
        public ObservableCollection<int> Bills { get; set; }

        public MachineViewModel()
        {
            Payment = new PaymentViewModel();
            Items = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel(1, "Cola", 200),
                new ProductViewModel(2, "Milk", 100),
                new ProductViewModel(3, "Water", 60),
                new ProductViewModel(4, "Mineral water", 120),
            };
            Bills = new ObservableCollection<int>() { 0, 0, 0, 0 };
        }

        public void Purchase(object item)
        {
            var requestedItem = item as ProductViewModel;

            Payment.SelectPrice(requestedItem.Information.Price);

            if (Payment.Confirm())
            {
                if (requestedItem.Dispense())
                {
                    Payment.Paid();
                    Bills[requestedItem.Id - 1] += 1;
                    Console.WriteLine("Payment success!");
                    OnPropertyChanged("ShowBills");
                }
                else
                {
                    Console.WriteLine("OUT OF STOCK");
                }
            }
            else
            {
                Console.WriteLine("Money not enough.");
            }
        }

        public void Insert(int money)
        {
            Payment.Insert(money);
        }
        public void CollectPayment()
        {
            Payment.CollectPayment();
        }
        public void Refill()
        {
            foreach(var item in Items)
            {
                item.Refill();
            }
            Console.WriteLine("Completed refill all.");
        }

        public void Empty()
        {
            foreach (var item in Items)
            {
                item.Empty();
            }
            Console.WriteLine("Completed empty all.");
        }

        public string ShowBills
        {
            get => ShowBill();
        }

        public bool EmptyBill()
        {
            ObservableCollection<int> empty = new ObservableCollection<int>() { 0, 0, 0, 0 };
            if (Bills == empty){
                return true;
            }
            return false;
        }
        public string ShowBill()
        {
            string BillString = "";
            for(int i=0; i<Items.Count; i++)
            {
                var item = Items[i].Information;
                if(Bills[item.Id-1] > 0)
                {
                    BillString += "x" +Bills[item.Id - 1]+ " " + item.Name + "\n";
                }
            }
            return BillString;
        }

        public void ClearBill()
        {
            Bills = new ObservableCollection<int>(){ 0,0,0,0 };
            OnPropertyChanged(ShowBills);
        }
    }
}
