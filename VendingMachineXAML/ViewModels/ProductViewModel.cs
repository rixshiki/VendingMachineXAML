using System;
using VendingMachineXAML.Models;

namespace VendingMachineXAML.ViewModels
{
    public class ProductViewModel : ObserverObject
    {
        private VendingItem _item;
        private int _quantity;
        const int MAX_QUANTITY = 10;

        public ProductViewModel(int id, string name, int price)
        {
            _item = new VendingItem(id, name, price);
            _quantity = MAX_QUANTITY;
        }

        public int Id {
            get => _item.Id;
        }

        public int Quantity
        {
            get => _quantity;
            private set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
                OnPropertyChanged("ShowItemQuantity");
            }
        }

        public VendingItem Information
        {
            get => _item;
        }

        public string ShowItemQuantity
        {
            get
            {
                if (Quantity > 0) return "LEFT: " + _quantity;
                else return "LEFT: OUT OF STOCK!";
            }
        }
        public string ShowItemPrice
        {
            get => "PRICE: " + _item.Price +" ฿";
        }

        public int Refill()
        {
            int diff = MAX_QUANTITY - Quantity;
            Quantity += diff;
            return diff;
        }

        public int Empty()
        {
            int diff = Quantity;
            Quantity = 0;
            return diff;
        }

        public bool Dispense()
        {
            if(Quantity > 0)
            {
                Quantity--;
                return true;
            }
            return false;
        }
    }
}
