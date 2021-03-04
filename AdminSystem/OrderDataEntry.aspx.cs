using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderNum = Convert.ToInt32(txtOrderNum.Text);
        string CustomerNum = txtCustomerNum.Text;
        string ItemNum = txtItemNum.Text;
        string DateFinalised = txtDateFinalised.Text;
        string StandaloneOrSet = txtStandaloneOrSet.Text;
        string Quantity = txtQuantity.Text;
        string TotalPrice = txtTotalPrice.Text;
        AnOrder.ReadyForShipping = chkReadyForShipping.Checked;
        string Error = "";
        Error = AnOrder.Valid(CustomerNum, ItemNum, DateFinalised, StandaloneOrSet, Quantity, TotalPrice);
        if (Error == "")
        {
            AnOrder.CustomerNum = Convert.ToInt32(CustomerNum);
            AnOrder.ItemNum = Convert.ToInt32(ItemNum);
            AnOrder.DateFinalised = Convert.ToDateTime(DateFinalised);
            AnOrder.StandaloneOrSet = StandaloneOrSet;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.TotalPrice = Convert.ToDouble(TotalPrice);
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNum;
        Boolean Found = false;
        OrderNum = Convert.ToInt32(txtOrderNum.Text);
        Found = AnOrder.Find(OrderNum);
        if (Found == true)
        {
            txtCustomerNum.Text = AnOrder.CustomerNum.ToString();
            txtItemNum.Text = AnOrder.ItemNum.ToString();
            txtDateFinalised.Text = AnOrder.DateFinalised.ToString();
            txtStandaloneOrSet.Text = AnOrder.StandaloneOrSet;
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
        }
    }
}