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

        clsStaff StaffMember = new clsStaff();

        string staffNum = txtStaffNumber.Text;
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string hourlyRate = txtHourlyRate.Text;
        string phoneNumber = txtPhoneNumber.Text;
        string startDate = txtStartDate.Text;

        if (StaffMember.Valid(staffNum, firstName, lastName, hourlyRate, phoneNumber, startDate) == false)
        {
            lblStaffNumberError.Text = StaffMember.ValidStaffNumber(staffNum);
            lblFirstNameError.Text = StaffMember.ValidName(firstName);
            lblLastNameError.Text = StaffMember.ValidName(lastName);
            lblHourlyRateError.Text = StaffMember.ValidHourlyRate(hourlyRate);
            lblPhoneNumberError.Text = StaffMember.ValidPhoneNumber(phoneNumber);
            lblStartDateError.Text = StaffMember.ValidStartDate(startDate);
        }
        else
        {
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
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creates new instance of staff class
        clsStaff StaffMember = new clsStaff();
        if (StaffMember.ValidStaffNumber(txtStaffNumber.Text) != "") //checks to see whether staff number is in correct format.
        {
            lblStaffNumberError.Text = StaffMember.ValidStaffNumber(txtStaffNumber.Text);
        }
        else //runs this bit if the format is correct
        {
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
}