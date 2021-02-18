using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //When the page loads and when the manager box is ticked.
    protected void Page_Load(object sender, EventArgs e){}
    protected void chkIsManager_CheckedChanged(object sender, EventArgs e){}

    //When the OK button is clicked
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create instance of StaffMember class
        //at the moment just blindly parses inputs to match the needed datatype with no validation. Will crash easily.
        clsStaff StaffMember = new clsStaff();
        StaffMember.StaffNumber = int.Parse(txtStaffNumber.Text);
        StaffMember.FirstName = txtFirstName.Text;
        StaffMember.LastName = txtLastName.Text;
        StaffMember.HourlyRate = decimal.Parse(txtHourlyRate.Text);
        StaffMember.IsManager = chkIsManager.Checked;
        StaffMember.PhoneNumber = txtPhoneNumber.Text;
        StaffMember.StartDate = System.DateTime.Parse(txtStartDate.Text);
        Session["StaffMember"] = StaffMember;
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creates new instance of staff class
        clsStaff StaffMember = new clsStaff();
        int StaffNumber;
        Boolean Found = false;
        StaffNumber = Convert.ToInt32(txtStaffNumber.Text);
        Found = StaffMember.Find(StaffNumber);

        if (Found)
        {
            //fill in the rest of the slots
            txtFirstName.Text = StaffMember.FirstName;
            txtLastName.Text = StaffMember.LastName;
            txtHourlyRate.Text = StaffMember.HourlyRate.ToString();
            txtPhoneNumber.Text = StaffMember.PhoneNumber;
            txtStartDate.Text = StaffMember.StartDate.ToString();
            chkIsManager.Checked = StaffMember.IsManager;
        }
    }
}