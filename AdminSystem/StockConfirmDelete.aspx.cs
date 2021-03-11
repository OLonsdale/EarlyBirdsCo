using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //store primary key
    Int32 ItemId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get id of the item to be deleted from session
        ItemId = Convert.ToInt32(Session["ItemId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of clsStockCollection
        clsStockCollection Stock = new clsStockCollection();
        //find record to delete
        Stock.ThisItem.Find(ItemId);
        //delete record
        Stock.Delete();
        //redirect to main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("StockList.aspx");
    }
}