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
        //create a new instance of clsStock
        clsStock AnItem = new clsStock();
        //receive the data from the session object
        AnItem = (clsStock)Session["AnItem"];
        //display the item properties for this entry 
        Response.Write(AnItem.ItemId);
        Response.Write(AnItem.ItemName);
        Response.Write(AnItem.Quantity);
        Response.Write(AnItem.Price);
        Response.Write(AnItem.Material);
        Response.Write(AnItem.LastPurchased);
        Response.Write(AnItem.InStock);
    }
}