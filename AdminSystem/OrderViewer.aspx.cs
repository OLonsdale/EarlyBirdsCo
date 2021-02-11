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
        Response.Write(AnOrder.OrderId);
        Response.Write("<br>");
        Response.Write(AnOrder.DateFinalised);
        Response.Write("<br>");
        Response.Write(AnOrder.ItemId);
        Response.Write("<br>");
        Response.Write(AnOrder.Quantity);
        Response.Write("<br>");
        Response.Write(AnOrder.TotalPrice);
        Response.Write("<br>");
        Response.Write(AnOrder.IsEmpty);
    }
}