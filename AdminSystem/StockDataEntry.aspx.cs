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
        AnItem.ItemId = int.Parse(txtItemId.Text);
        AnItem.ItemName = txtItemName.Text;
        AnItem.Quantity = int.Parse(txtQuantity.Text);
        AnItem.Price = double.Parse(txtPrice.Text);
        AnItem.Material = txtMaterial.Text;
        AnItem.LastPurchased = DateTime.Parse(txtLastPurchased.Text);
        AnItem.InStock = chkInStock.Checked;
        //store the properties in the session object
        Session["AnItem"] = AnItem;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");//
    }

   /* protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock AnItem = new clsStock();
        Int32 ItemId;
        Boolean Found = false;
        ItemId = Convert.ToInt32(txtItemId.Text);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtItemName.Text = AnItem.ItemName;
            txtQuantity.Text = AnItem.Quantity;
            txtPrice.Text = AnItem.Price;
            txtMaterial.Text = AnItem.Material;
            txtLastPurchased.Text = AnItem.LastPurchased.ToString();          
      
        }
    } */
}