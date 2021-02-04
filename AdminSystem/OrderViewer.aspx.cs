using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.orderId);
        Response.Write("<br>");
        Response.Write(AnOrder.dateFinalised);
        Response.Write("<br>");
        Response.Write(AnOrder.itemId);
        Response.Write("<br>");
        Response.Write(AnOrder.quantity);
        Response.Write("<br>");
        Response.Write(AnOrder.totalPrice);
        Response.Write("<br>");
        Response.Write(AnOrder.isEmpty);
    }
}