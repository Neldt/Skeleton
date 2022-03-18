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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            lblError.Text = "";
            //display the values of the properties in the form
            txtName.Text = ACustomer.Name;
            txtEmail.Text = ACustomer.Email;
            txtAddress.Text = ACustomer.Address;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            if (ACustomer.ReceiveMarketing == true)
            {
                chkReceiveMarketing.Checked = true;
            }
            else
            {
                chkReceiveMarketing.Checked = false;
            }
        }
        else
        {
            lblError.Text = "Error CustomerID Not Found";
        }
    }
}