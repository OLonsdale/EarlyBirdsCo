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
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.DateFinalised = Convert.ToDateTime(txtDateFinalised.Text);
        AnOrder.ItemId = txtItemId.Text;
        AnOrder.Quantity = Convert.ToInt16(txtQuantity.Text);
        AnOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
        AnOrder.IsEmpty = chkIsEmpty.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}