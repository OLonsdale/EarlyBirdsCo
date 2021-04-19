using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Home_Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnShipping_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShippingList.aspx");
    }
}