using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagementSystem
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        List<IOrder> orderList = new List<IOrder>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //CompareValidator1.ValueToCompare
            if (!Page.IsPostBack)
            {
                populateCategory();
                ddlProduct.Items.Insert(0, "Select");
            }
        }

        private void populateCategory()
        {

            
            ddlCategory.Items.Clear();
            ddlCategory.Items.Insert(0, "Select");
            ddlCategory.Items.Add("Electronics");
            ddlCategory.Items.Add("Kitchen Ware");

        }
        private void populateProduct()
        {
            ddlProduct.Items.Clear();
            ddlProduct.Items.Insert(0, "Select");
          
            if (ddlCategory.Text == "Electronics")
            {
                ddlProduct.Items.Add("HP Printer");
                ddlProduct.Items.Add("Pen Drive");
            }
            else if (ddlCategory.Text == "Kitchen Ware")
            {
                ddlProduct.Items.Add("Thermo Steel Flask");
                ddlProduct.Items.Add("Electronic Tiffin Box");
            }

        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateProduct();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try { 
            if (Page.IsValid)
            {
                IOrder orderObj = new Order();
                orderObj.Category=ddlCategory.Text;
                    orderObj.Product=ddlProduct.Text;

                    orderObj.UnitPrice=int.Parse(txtUnitprice.Text);

                        orderObj.Quantity=int.Parse(txtQuantity.Text);

                        orderObj.Discount = txtDiscount.Text;

                        orderObj.TotalAmount=double.Parse(txtTotalAmount.Text);

                //orderObj.RequiredByDate=DateTime.Parse(txtRequiredByDate.Text);
                
                orderList.Add(orderObj);

                Session["Orderdata"] = orderList;

                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Order placed successfully”');", true);
            }

            }
        catch(Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:"+ ex.Message+"');", true);
            }
            
            
            
            }

        protected void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProduct.Text == "HP Printer")
            {
                
                txtUnitprice.Text = (13000).ToString();
            }
            else if (ddlProduct.Text == "Pen Drive")
            {
                txtUnitprice.Text = (600).ToString();
                
            }
            else if (ddlProduct.Text == "Thermo Steel Flask")
            {
              
                txtUnitprice.Text = (730).ToString();
            }
            else if (ddlProduct.Text == "Electronic Tiffin Box")
            {
               
                txtUnitprice.Text = (1300).ToString();
            }

        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int count = int.Parse(txtQuantity.Text);
            double flag = 0;
            if ((ddlProduct.Text == "HP Printer") && (count >= 1))
            {
                txtDiscount.Text = " 20%";
                flag = 0.20;
            }
            else if ((ddlProduct.Text == "Pen Drive") && (count >= 3))
            {
                txtDiscount.Text = " 20%";
                flag = 0.20;
            }
            else if ((ddlProduct.Text == "Thermo Steel Flask") && (count >= 3))
            {
                txtDiscount.Text = " 10%";
                flag = 0.10;
            }
            else if ((ddlProduct.Text == "Electronic Tiffin Box") && (count >= 2))
            {
                txtDiscount.Text = " 20%";
                flag = 0.20;
            }
            else
            {
                txtDiscount.Text = " 0%";
            }


            txtTotalAmount.Text = ((double.Parse(txtUnitprice.Text)) * (double.Parse(txtQuantity.Text)) - (flag * ((double.Parse(txtUnitprice.Text)) * (double.Parse(txtQuantity.Text))))).ToString();

        }
    }
}