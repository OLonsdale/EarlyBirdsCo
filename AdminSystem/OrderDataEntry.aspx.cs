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
        clsOrder AnOrder = new clsOrder();
        AnOrder.orderId = txtOrderId.Text;
        AnOrder.dateFinalised = Convert.ToDateTime(txtDateFinalised.Text);
        AnOrder.itemId = txtItemId.Text;
        AnOrder.quantity = Convert.ToInt16(txtQuantity.Text);
        AnOrder.totalPrice = Convert.ToDouble(txtTotalPrice.Text);
        AnOrder.isEmpty = chkIsEmpty.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}