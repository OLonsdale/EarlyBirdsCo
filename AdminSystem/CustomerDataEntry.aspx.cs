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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        ACustomer.Name = txtName.Text;
        // ACustomer.DateOfBirth = "";
        ACustomer.Address = txtAddress.Text;
        ACustomer.Email = txtEmail.Text;
        ACustomer.UserPassword = txtPassword.Text;
        ACustomer.IsMember = chkIsMember.Checked;

        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}