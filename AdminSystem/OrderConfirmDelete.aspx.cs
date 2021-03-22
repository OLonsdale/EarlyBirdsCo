using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderNum;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNum = Convert.ToInt32(Session["OrderNum"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderNum);
        OrderList.Delete();
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}