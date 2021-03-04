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
        Response.Write(AnOrder.OrderNum);
        Response.Write("<br>");
        Response.Write(AnOrder.CustomerNum);
        Response.Write("<br>");
        Response.Write(AnOrder.ItemNum);
        Response.Write("<br>");
        Response.Write(AnOrder.DateFinalised);
        Response.Write("<br>");
        Response.Write(AnOrder.StandaloneOrSet);
        Response.Write("<br>");
        Response.Write(AnOrder.Quantity);
        Response.Write("<br>");
        Response.Write(AnOrder.TotalPrice);
        Response.Write("<br>");
        Response.Write(AnOrder.ReadyForShipping);
    }
}