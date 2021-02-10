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
        Response.Write(AnItem.itemID);
        Response.Write(AnItem.itemName);
        Response.Write(AnItem.quantity);
        Response.Write(AnItem.price);
        Response.Write(AnItem.material);
        Response.Write(AnItem.lastPurchased);
        Response.Write(AnItem.inStock);
       
        
    }
}