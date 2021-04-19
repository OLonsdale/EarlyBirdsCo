using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff StaffMember = new clsStaff();
        StaffMember.Find(Convert.ToInt32(Session["StaffNumber"]));

        StaffNumber.Text = StaffMember.StaffNumber.ToString();
        FirstName.Text = StaffMember.FirstName;
        LastName.Text = StaffMember.LastName;
        HourlyRate.Text = StaffMember.HourlyRate.ToString();
        PhoneNumber.Text = StaffMember.PhoneNumber;
        StartDate.Text = StaffMember.StartDate.ToString();
        if (StaffMember.IsManager == true)
        {
            IsManager.Text = "Yes";
        }
        else IsManager.Text = "No";
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}