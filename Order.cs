using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem
{
    public class Order : OrderManagementSystem.IOrder
    {
        string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        int unitPrice;

        public int UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }


        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        string discount;

        public string Discount
        {
            get { return discount; }
            set { discount = value; }
        }

       
        double totalAmount;

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        DateTime requiredByDate;

        public DateTime RequiredByDate
        {
            get { return requiredByDate; }
            set { requiredByDate = value; }
        }
    }
}