using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderNum;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNum = Convert.ToInt32(Session["OrderNum"]);
        if (IsPostBack == false)
        {
            if (OrderNum != -1)
            {
                DisplayAddress();
            }
        }
    }

    public void DisplayAddress()
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderNum);
        txtOrderNum.Text = OrderList.ThisOrder.OrderNum.ToString();
        txtCustomerNum.Text = OrderList.ThisOrder.CustomerNum.ToString();
        txtItemNum.Text = OrderList.ThisOrder.ItemNum.ToString();
        txtDateFinalised.Text = OrderList.ThisOrder.DateFinalised.ToString();
        txtStandaloneOrSet.Text = OrderList.ThisOrder.StandaloneOrSet;
        txtQuantity.Text = OrderList.ThisOrder.Quantity.ToString();
        txtTotalPrice.Text = OrderList.ThisOrder.TotalPrice.ToString();
        chkReadyForShipping.Checked = OrderList.ThisOrder.ReadyForShipping;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
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
            AnOrder.OrderNum = OrderNum;
            AnOrder.CustomerNum = Convert.ToInt32(CustomerNum);
            AnOrder.ItemNum = Convert.ToInt32(ItemNum);
            AnOrder.DateFinalised = Convert.ToDateTime(DateFinalised);
            AnOrder.StandaloneOrSet = StandaloneOrSet;
            AnOrder.Quantity = Convert.ToInt32(Quantity);
            AnOrder.TotalPrice = Convert.ToDouble(TotalPrice);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderNum == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNum);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}