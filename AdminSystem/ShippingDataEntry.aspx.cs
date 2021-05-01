using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ShippingId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ShippingId = Convert.ToInt32(Session["ShippingId"]);
        if (IsPostBack == false)
        {
            if (ShippingId != 1)
            {
                DisplayShipment();
            }
        }
    }

    protected void lstShippingType_SelectedIndexChanged(object sender, EventArgs e)
    {
        clsShipping AShipment = new clsShipping();
        if (lstShippingType.SelectedIndex == 1)
        {
            AShipment.Price = 4.99m;
            txtPrice.Text = "4.99";
        }
        else if (lstShippingType.SelectedIndex == 2)
        {
            AShipment.Price = 7.99m;
            txtPrice.Text = "7.99";
        }
        else
        {
            txtPrice.Text = "";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        lblError.Text = "";

        clsShipping AShipment = new clsShipping();

        string ShippingType = lstShippingType.Text;
        string Price = txtPrice.Text;
        string DateOfDispatch = txtDateOfDispatch.Text; 
        
        //Error message
        String Error = "";
        Error = AShipment.Valid(DateOfDispatch);

        if(lstShippingType.SelectedIndex == 0)
        {
            Error += "Select a Shipping Type : ";
        }

        if (Error == "")
        {
            //capture properties
            AShipment.ShippingId = ShippingId;
            AShipment.ShippingType = ShippingType;
            //populate Price field based on Shipping Type selection
            if (lstShippingType.SelectedIndex == 1 || lstShippingType.SelectedIndex == 2) {
                AShipment.Price = Decimal.Parse(Price);
            }   
            //define value of Dispatched boolean based on if a date of dispatch was input
            if (DateOfDispatch.Length == 0)
            {
                DateOfDispatch = null;
                AShipment.Dispatched = false;
            }
            else
            {
                AShipment.DateOfDispatch = Convert.ToDateTime(DateOfDispatch);
                AShipment.Dispatched = true;
            }

            clsShippingCollection ShippingList = new clsShippingCollection();

            if (ShippingId == -1)
            {
                ShippingList.ThisShipment = AShipment;
                ShippingList.Add();
            }
            else
            {
                ShippingList.ThisShipment.Find(ShippingId);
                ShippingList.ThisShipment = AShipment;
                ShippingList.Update();
            }
            Response.Redirect("ShippingList.aspx");
        } else
        {
            lblError.Text = Error;
        }

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";

        clsShipping AShipment = new clsShipping();

        Int32 ShippingId;
        Boolean Found = false;

        ShippingId = Convert.ToInt32(txtShippingId.Text);

        Found = AShipment.Find(ShippingId);

        if (Found == true)
        {
            lstShippingType.SelectedValue = AShipment.ShippingType;
            txtPrice.Text = AShipment.Price.ToString();
            if (txtDateOfDispatch.Text == null)
            {
                //do nothing
            }
            else
            {
                txtDateOfDispatch.Text = AShipment.DateOfDispatch.ToString();
            }
        }
        else
        {
            //reset the text boxes to empty
            txtShippingId.Text = "";
            lstShippingType.SelectedIndex = 0;
            txtPrice.Text = "";
            txtDateOfDispatch.Text = "";
            //output an error message
            lblError.Text = "Error! Item does not exist";
        }
    }

    private void DisplayShipment()
    {
        clsShippingCollection AllShipments = new clsShippingCollection();

        AllShipments.ThisShipment.Find(ShippingId);

        txtShippingId.Text = AllShipments.ThisShipment.ShippingId.ToString();
        lstShippingType.SelectedValue = AllShipments.ThisShipment.ShippingType;
        txtPrice.Text = AllShipments.ThisShipment.Price.ToString();
        txtDateOfDispatch.Text = AllShipments.ThisShipment.DateOfDispatch.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShippingList.aspx");
    }
}