using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnItem = new clsStock();
        //obtain the item's properties
        AnItem.itemID = int.Parse(txtItemId.Text);
        AnItem.itemName = txtItemName.Text;
        AnItem.quantity = int.Parse(txtQuantity.Text);
        AnItem.price = double.Parse(txtPrice.Text);
        AnItem.material = txtMaterial.Text;
        AnItem.lastPurchased = DateTime.Parse(txtLastPurchased.Text);
        AnItem.inStock = chkInStock.Checked;
        //store the properties in the session object
        Session["AnItem"] = AnItem;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}