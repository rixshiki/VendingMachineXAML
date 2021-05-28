﻿using System;

namespace VendingMachineXAML.Models
{
    public class VendingItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public VendingItem(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
