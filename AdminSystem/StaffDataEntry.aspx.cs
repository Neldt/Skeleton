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
        clsStaff AStaff = new clsStaff();

        ASaff.StaffID = Convert.ToInt32(textStaffID.Text);
        ASaff.CustomerID = Convert.ToInt32(textCustomerID.Text);
        ASaff.StaffFullName = textStaffFullName.Text;
        ASaff.Availability = Convert.ToBoolean(textAvailability.Text);
        ASaff.StaffRole = textStaffRole.Text;
        ASaff.StartDate = Convert.ToDateTime(textStartDate.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}