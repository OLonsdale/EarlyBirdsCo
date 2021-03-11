using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page //_1_List
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if first time page being displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set data source to list of items in the collection
        lstStock.DataSource = Stock.StockList;
        //set name of primary key
        lstStock.DataValueField = "ItemId";
        //set data field to display
        lstStock.DataTextField = "ItemName";
        //bind data to list
        lstStock.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session objecvt to indicate new record
        Session["ItemId"] = -1;
        //redirect to data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //store primary key of record to edit
        Int32 ItemId;
        //if record has been selected from list
        if (lstStock.SelectedIndex != -1)
        {
            //get primary key of record to edit
            ItemId = Convert.ToInt32(lstStock.SelectedValue);
            //store data in session
            Session["ItemId"] = ItemId;
            //redirect to edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list.";
        }
    }
}