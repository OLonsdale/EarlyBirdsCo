using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAddresses();
        }
    }

    void DisplayAddresses()
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderNum";
        lstOrderList.DataTextField = "OrderNum";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNum"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNum;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNum = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNum"] = OrderNum;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNum;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNum = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNum"] = OrderNum;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ReportByKeyType(txtFilter.Text);
        lstOrderList.DataSource = OrderList.OrderList;
        lstOrderList.DataValueField = "OrderNum";
        lstOrderList.DataTextField = "OrderNum";
        lstOrderList.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ReportByKeyType("");
        lstOrderList.DataSource = OrderList.OrderList;
        lstOrderList.DataValueField = "OrderNum";
        lstOrderList.DataTextField = "OrderNum";
        lstOrderList.DataBind();
    }
}