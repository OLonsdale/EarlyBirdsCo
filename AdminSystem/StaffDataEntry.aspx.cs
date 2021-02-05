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
        //create instance of staffMember class
        //at the moment just blindly parses inputs to match
        clsStaff staffMember = new clsStaff();
        staffMember.staffNumber = int.Parse(txtStaffNumber.Text);
        staffMember.firstName = txtFirstName.Text;
        staffMember.lastName = txtLastName.Text;
        staffMember.hourlyRate = decimal.Parse(txtHourlyRate.Text);
        //staffMember.isManager = bool.Parse(chkIsManager.Text);    //don't know how to parse the value returned by a checkbox
        staffMember.phoneNumber = txtPhoneNumber.Text;
        staffMember.startDate = System.DateTime.Parse(txtStartDate.Text);
        Session["staffMember"] = staffMember;
        Response.Redirect("StaffViewer.aspx");
    }

    protected void chkIsManager_CheckedChanged(object sender, EventArgs e)
    {

    }
}