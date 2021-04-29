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
        clsShipping AShipment = new clsShipping();
        string ShippingId = txtShippingId.Text;
        string ShippingType = txtShippingType.Text;
        string Price = txtPrice.Text;
        string DateOfDispatch = txtDateOfDispatch.Text;
        AShipment.Dispatched = chkDispatched.Checked;

        AShipment.ShippingId = Convert.ToInt32(txtShippingId.Text);
        AShipment.ShippingType = txtShippingType.Text;
        AShipment.Price = Convert.ToDecimal(txtPrice.Text);
        AShipment.DateOfDispatch = Convert.ToDateTime(txtDateOfDispatch.Text);
        AShipment.Dispatched = Convert.ToBoolean(chkDispatched.Checked);

        Session["AShipment"] = AShipment;
        Response.Redirect("ShippingViewer.aspx");
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
            txtShippingType.Text = AShipment.ShippingType;
            txtPrice.Text = AShipment.Price.ToString();
            txtDateOfDispatch.Text = AShipment.DateOfDispatch.ToString();
            chkDispatched.Checked = AShipment.Dispatched;

        }
    }
}