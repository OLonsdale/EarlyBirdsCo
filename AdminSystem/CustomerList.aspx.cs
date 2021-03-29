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
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "Email";
        lstCustomerList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(txtEnterName.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName("");
        txtEnterName.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }
}