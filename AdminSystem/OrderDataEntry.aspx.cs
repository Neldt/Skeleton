using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string PhoneNumber = txtPhoneNumber.Text;

        string ItemQuantity = txtItemQuantity.Text;

        string DeliveryTime = txtDeliveryTime.Text;

        string DeliveryAddress = txtDeliveryAddress.Text;

        string Error = "";

        Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

        if(Error == "")
        {
            AnOrder.PhoneNumber = Convert.ToInt64(PhoneNumber);

            AnOrder.ItemQuantity = Convert.ToInt32(ItemQuantity);

            AnOrder.DeliveryTime = Convert.ToDateTime(DeliveryTime);

            AnOrder.DeliveryAddress = DeliveryAddress;

            //store the address in the session object
            Session["AnOrder"] = AnOrder;
            //Navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void lblFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtPhoneNumber.Text = AnOrder.PhoneNumber.ToString();

            txtItemQuantity.Text = AnOrder.ItemQuantity.ToString();

            txtDeliveryTime.Text = AnOrder.DeliveryTime.ToString();

            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;

            txtNotes.Text = AnOrder.Notes;
        }
    }
}