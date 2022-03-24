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
        int CustomerIDint = 0;
        Int32.TryParse(txtCustomerID.Text, out CustomerIDint);
        
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string DateAdded = txtDateAdded.Text;
        //send string values to validate method
        string Error = "";
        Error = ACustomer.Valid(Name, Email, Address, DateAdded);
        if(Error == "")
        {
            ACustomer.CustomerID = CustomerIDint;
            ACustomer.Name = Name;
            ACustomer.Email = Email;
            ACustomer.Address = Address;
            DateTime Date = Convert.ToDateTime(DateAdded);
            ACustomer.DateAdded = Date;

            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


        
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