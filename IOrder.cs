using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderManagementSystem
{
    interface IOrder
    {
        string Category { get; set; }
        string Discount { get; set; }
        string Product { get; set; }
        int Quantity { get; set; }
        DateTime RequiredByDate { get; set; }
        double TotalAmount { get; set; }
        int UnitPrice { get; set; }
    }
}
