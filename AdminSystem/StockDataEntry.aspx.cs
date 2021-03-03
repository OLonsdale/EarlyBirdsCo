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

    //OK button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnItem = new clsStock();
        //obtain the item's properties
        //string ItemId = txtItemId.Text;
        string ItemName = txtItemName.Text;
        string Price = txtPrice.Text;
        string Material = txtMaterial.Text;
        string LastPurchased = txtLastPurchased.Text;
        string Quantity = txtQuantity.Text;
        //store error message
        string Error = "";
        //validate data
        Error = AnItem.Valid(ItemName, Price, Material, LastPurchased, Quantity);
        if (Error == "")
        {
            //capture the properties
            AnItem.ItemName = ItemName;
            AnItem.Price = Double.Parse(Price);
            AnItem.Material = Material;
            AnItem.LastPurchased = Convert.ToDateTime(LastPurchased);
            AnItem.Quantity = Int32.Parse(Quantity);
            //store the properties in the session object
            Session["AnItem"] = AnItem;
            //navigate to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    //Find button

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock AnItem = new clsStock();
        //variable to store the primary key
        Int32 ItemId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ItemId = Convert.ToInt32(txtItemId.Text);
        //Find the record
        Found = AnItem.Find(ItemId);
        //if found...
        if (Found)
        {
            //display the values of the properties in the form
            txtItemName.Text = AnItem.ItemName;
            txtQuantity.Text = AnItem.Quantity.ToString();
            txtPrice.Text = AnItem.Price.ToString();
            txtMaterial.Text = AnItem.Material;
            txtLastPurchased.Text = AnItem.LastPurchased.ToString();
            chkInStock.Checked = AnItem.InStock;
        }
        //if record does not exist...
        else
        {
            //reset the text boxes to empty
            txtItemName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtMaterial.Text = "";
            txtLastPurchased.Text = "";
            chkInStock.Checked = false;
            //output an error message
            lblError.Text = "Error! No Such Item Exists.";
        }
    }
}