using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //Int32 ShippingId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get id of the item to be deleted from session
        //ShippingId = Convert.ToInt32(Session["ShippingId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        /*
        //create new instance of clsStockCollection
        clsShippingCollection AllShipments = new clsShippingCollection();
        //find record to delete
        AllShipments.ThisShipment.Find(ShippingId);
        //delete record
        AllShipments.Delete();
        //redirect to main page
        Response.Redirect("ShippingList.aspx"); */
    } 

    protected void btnNo_Click(object sender, EventArgs e)
    {
        /*
        //redirect to main page
        Response.Redirect("ShippingList.aspx"); */
    }
}