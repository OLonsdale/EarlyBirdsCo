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
        clsShipping AShipment = new clsShipping();
        string ShippingId = txtShippingId.Text;
        string ShippingType = lstShippingType.Text;
        string Price = txtPrice.Text;
        string DateOfDispatch = txtDateOfDispatch.Text;
        //AShipment.Dispatched = chkDispatched.Checked;
        
        String Error = "";
        Error = AShipment.Valid(DateOfDispatch);

        if(lstShippingType.SelectedIndex == 0)
        {
            Error += "Select a Shipping Type : ";
        }

        if (Error == "")
        {
            //capture properties
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
            Session["AShipment"] = AShipment;
            Response.Redirect("ShippingViewer.aspx");
        } else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsShipping AShipment = new clsShipping();
        Int32 ShippingId;
        Boolean Found = false;
        ShippingId = Convert.ToInt32(txtShippingId.Text);
        Found = AShipment.Find(ShippingId);
        if (Found == true) {
            txtShippingId.Text = AShipment.ShippingId.ToString();
            lstShippingType.Text = AShipment.ShippingType;
            txtPrice.Text = AShipment.Price.ToString();
            txtDateOfDispatch.Text = AShipment.DateOfDispatch.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShippingList.aspx");
    }
}