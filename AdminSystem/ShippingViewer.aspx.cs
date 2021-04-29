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
        clsShipping AShipment = new clsShipping();
        AShipment = (clsShipping)Session["AShipment"];
        Response.Write(AShipment.ShippingId);
        Response.Write(AShipment.ShippingType);
        Response.Write(AShipment.Price);
        Response.Write(AShipment.DateOfDispatch);
        Response.Write(AShipment.Dispatched);
    }
}