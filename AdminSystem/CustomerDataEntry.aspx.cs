using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        //capture customer id
        int CustomerIDint= 0;
        Int32.TryParse(txtCustomerID.Text, out CustomerIDint);
        ACustomer.CustomerID = CustomerIDint;
        //capture name
        ACustomer.Name = txtName.Text;
        
        //capture Email
        ACustomer.Email = txtEmail.Text;
        
        //capture Address
        ACustomer.Address = txtAddress.Text;
        
        //capture Date Added
        string Date = txtDateAdded.Text;
        DateTime Datex = Convert.ToDateTime(Date);
        ACustomer.DateAdded = Datex;
        

        //store in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}