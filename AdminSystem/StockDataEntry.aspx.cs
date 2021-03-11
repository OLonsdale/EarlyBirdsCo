using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //store primary key with page level scope
    Int32 ItemId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the item to be processed
        ItemId = Convert.ToInt32(Session["ItemId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ItemId != -1)
            {
                //display current data for record
                DisplayAddress();
            }
        }
    }

    //OK button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //reset error message
        lblError.Text = "";

        //create a new instance of clsStock
        clsStock AnItem = new clsStock();

        //obtain the item's properties
        String ItemName = txtItemName.Text;
        String Price = txtPrice.Text;
        String Material = txtMaterial.Text;
        String LastPurchased = txtLastPurchased.Text;
        String Quantity = txtQuantity.Text;

        //validate data
        if (AnItem.Valid(ItemName, Price, Material, LastPurchased, Quantity) == false)
        {
            lblError.Text += AnItem.ValidItemName(ItemName);
            lblError.Text += AnItem.ValidPrice(Price);
            lblError.Text += AnItem.ValidMaterial(Material);
            lblError.Text += AnItem.ValidLastPurchased(LastPurchased);
            lblError.Text += AnItem.ValidQuantity(Quantity);
        }
        else
        {
            //capture the properties
            AnItem.ItemId = ItemId;
            AnItem.ItemName = ItemName;
            AnItem.Price = Decimal.Parse(Price);
            AnItem.Material = Material;
            if (LastPurchased.Length == 0)
            {
                LastPurchased = null;
            }
            else
            {
                AnItem.LastPurchased = Convert.ToDateTime(LastPurchased);
            }
            AnItem.Quantity = Int32.Parse(Quantity);
            AnItem.InStock = chkInStock.Checked;
            //create new instance of clsStockCollection
            clsStockCollection StockList = new clsStockCollection();
            if (ItemId == -1)
            {
                 //set ThisItem property
                 StockList.ThisItem = AnItem;
                 //add new record
                 StockList.Add();
            }
           //otherwise update
           else
           {
                //find record to update
                StockList.ThisItem.Find(ItemId);
                //set ThisItem property
                StockList.ThisItem = AnItem;
                //update record
                StockList.Update();
           }
            //redirect back to list page
            Response.Redirect("StockList.aspx");
        }
    }

    //Find button
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //reset error message
        lblError.Text = "";

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
            if (txtLastPurchased.Text == null)
            {
                //do nothing
            } 
            else
            {
                txtLastPurchased.Text = AnItem.LastPurchased.ToString();
            }
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

    void DisplayAddress()
    {
        //create an instance of clsStockCollection
        clsStockCollection Stock = new clsStockCollection();
        //find record to update
        Stock.ThisItem.Find(ItemId);
        //display data for record
        txtItemId.Text = Stock.ThisItem.ItemId.ToString();
        txtItemName.Text = Stock.ThisItem.ItemName;
        txtPrice.Text = Stock.ThisItem.Price.ToString();
        txtMaterial.Text = Stock.ThisItem.Material;
        txtQuantity.Text = Stock.ThisItem.Quantity.ToString();
        txtLastPurchased.Text = Stock.ThisItem.LastPurchased.ToString();
        chkInStock.Checked = Stock.ThisItem.InStock;

    }
}