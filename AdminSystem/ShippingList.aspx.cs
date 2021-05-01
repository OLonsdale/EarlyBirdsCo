using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update list box
            DisplayAllShipments();
        }
    }

    void DisplayAllShipments() 
    {
        clsShippingCollection AllShipments = new clsShippingCollection();
        lstShippingList.DataSource = AllShipments.ShippingList;
        lstShippingList.DataValueField = "ShippingId";
        lstShippingList.DataTextField = "ShippingId";//what to show on the list box
        lstShippingList.DataBind();       
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ShippingId"] = -1;
        Response.Redirect("ShippingDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //store primary key of record to edit
        Int32 ShippingId;
        if (lstShippingList.SelectedIndex != -1)
        {
            //get primary key of record to edit
            ShippingId = Convert.ToInt32(lstShippingList.SelectedValue);
            Session["ShippingId"] = ShippingId;
            Response.Redirect("ShippingDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record to update.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //store primary key
        Int32 ShippingId;
        //if record has been selected from list 
        if (lstShippingList.SelectedIndex != -1)
        {
            //get primary key of record to delete
            ShippingId = Convert.ToInt32(lstShippingList.SelectedValue);
            //store data in session
            Session["ShippingId"] = ShippingId;
            //redirect to delete page
            Response.Redirect("ShippingConfirmDelete.aspx");
        }
        else 
        {
            //display error
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnDispatched_Click(object sender, EventArgs e)
    {    
        clsShippingCollection Shipments = new clsShippingCollection();
        Shipments.ReportByDispatchedTrue();
        lstShippingList.DataSource = Shipments.ShippingList;
        //set name of primary key
        lstShippingList.DataValueField = "ShippingId";
        //set name of field to display
        lstShippingList.DataTextField = "ShippingId";
        //bind data to the list
        lstShippingList.DataBind();
    }

    protected void btnAllOrders_Click(object sender, EventArgs e)
    {
        clsShippingCollection Shipments = new clsShippingCollection();
        Shipments.ClearFilter();
        lstShippingList.DataSource = Shipments.ShippingList;
        //set name of primary key
        lstShippingList.DataValueField = "ShippingId";
        //set name of field to display
        lstShippingList.DataTextField = "ShippingId";
        //bind data to the list
        lstShippingList.DataBind();
    }
}