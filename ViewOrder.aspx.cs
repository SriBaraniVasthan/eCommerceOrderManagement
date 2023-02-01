using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagementSystem
{
    public partial class ViewOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<IOrder> orderList = new List<IOrder>();
            Order orderObj = new Order();
            orderList = (List<IOrder>)Session["Orderdata"];

            foreach(IOrder temp  in orderList)
            {

                 TextBox3.Text= temp.Category;
              TextBox1.Text=temp.Product;

            txtUnitprice.Text=temp.UnitPrice.ToString();

           txtQuantity.Text= temp.Quantity.ToString() ;

           txtDiscount.Text= temp.Discount ;

           txtTotalAmount.Text = temp.TotalAmount.ToString();
            }
            
        }
    }
}