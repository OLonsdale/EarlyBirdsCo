using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int StaffNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNumber = Convert.ToInt32(Session["StaffNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(StaffNumber);
        StaffList.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}