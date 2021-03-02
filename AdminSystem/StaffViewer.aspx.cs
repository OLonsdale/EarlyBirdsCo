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
        StaffMember = (clsStaff)Session["StaffMember"];
        Response.Write(StaffMember.StaffNumber);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }
}