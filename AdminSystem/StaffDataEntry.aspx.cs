using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int StaffNumber;
    //When the page loads and when the manager box is ticked.
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNumber = Convert.ToInt32(Session["StaffNumber"]);
        if(IsPostBack == false)
        {
            if (StaffNumber != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ThisStaff.Find(StaffNumber);

        txtStaffNumber.Text = AllStaff.ThisStaff.StaffNumber.ToString();
        txtFirstName.Text = AllStaff.ThisStaff.FirstName;
        txtLastName.Text = AllStaff.ThisStaff.LastName;
        txtHourlyRate.Text = Math.Round(AllStaff.ThisStaff.HourlyRate,2).ToString();
        txtPhoneNumber.Text = AllStaff.ThisStaff.PhoneNumber;
        txtStartDate.Text = Convert.ToDateTime(AllStaff.ThisStaff.StartDate).ToShortDateString();
        chkIsManager.Checked = AllStaff.ThisStaff.IsManager;
    }

    protected void chkIsManager_CheckedChanged(object sender, EventArgs e){}

    //When the OK button is clicked
    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff StaffMember = new clsStaff();

        //capture the data from the text input boxes
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string hourlyRate = txtHourlyRate.Text;
        string phoneNumber = txtPhoneNumber.Text;
        string startDate = txtStartDate.Text;

        //if there are errors
        if (StaffMember.Valid(firstName, lastName, phoneNumber, hourlyRate, startDate) == false)
        {
            //add the error messages to their relevent boxes
            lblFirstNameError.Text = StaffMember.ValidName(firstName);
            lblLastNameError.Text = StaffMember.ValidName(lastName);
            lblHourlyRateError.Text = StaffMember.ValidHourlyRate(hourlyRate);
            lblPhoneNumberError.Text = StaffMember.ValidPhoneNumber(phoneNumber);
            lblStartDateError.Text = StaffMember.ValidStartDate(startDate);
        }
        //or, store the captured data in an instance of the class
        else if (StaffMember.Valid(firstName, lastName, phoneNumber, hourlyRate, startDate) == true)
        {
            StaffMember.StaffNumber = StaffNumber;
            StaffMember.FirstName = firstName;
            StaffMember.LastName = lastName;
            StaffMember.HourlyRate = decimal.Parse(hourlyRate);
            StaffMember.IsManager = chkIsManager.Checked;
            StaffMember.PhoneNumber = phoneNumber;
            StaffMember.StartDate = DateTime.Parse(startDate);

            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffNumber == -1)
            {
                StaffList.ThisStaff = StaffMember;
                StaffList.Add();
            }

            else
            {
                StaffList.ThisStaff.Find(StaffNumber);
                StaffList.ThisStaff = StaffMember;
                StaffList.Update();
            }

            Response.Redirect("StaffList.aspx");
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

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}