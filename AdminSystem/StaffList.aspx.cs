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
            DisplayStaffNumbers();
        }
    }

    void DisplayStaffNumbers()
    {
        clsStaffCollection StaffMembers = new clsStaffCollection();
        lstStaffNumberList.DataSource = StaffMembers.StaffList;
        lstStaffNumberList.DataValueField = "StaffNumber";
        lstStaffNumberList.DataTextField  = "FirstName";
        lstStaffNumberList.DataBind();
    }

    protected void lstStaffNumberList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}