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

        string Name = txtName.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Address = txtAddress.Text;
        string Email = txtEmail.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, DateOfBirth, Address, Email);

        if (Error == "")
        {
            ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            ACustomer.Name = Name;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.Address = Address;
            ACustomer.Email = Email;
            ACustomer.IsMember = chkIsMember.Checked;

            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        int CustomerId = Convert.ToInt32(txtCustomerId.Text);
        bool Found = false;
        Found = ACustomer.Find(CustomerId);

        if (Found)
        {
            txtName.Text = ACustomer.Name;
            txtDateOfBirth.Text = Convert.ToString(ACustomer.DateOfBirth);
            txtAddress.Text = ACustomer.Address;
            txtEmail.Text = ACustomer.Email;

            if (ACustomer.IsMember)
            {
                chkIsMember.Checked = true;
            }
            else
            {
                chkIsMember.Checked = false;
            }
        }
    }
}