using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();

        Order.ThisOrder.Find(OrderID);

        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtPhoneNumber.Text = Order.ThisOrder.PhoneNumber.ToString();
        txtItemQuantity.Text = Order.ThisOrder.ItemQuantity.ToString();
        chkDelivered.Checked = Order.ThisOrder.Delivery;
        txtDeliveryTime.Text = Order.ThisOrder.DeliveryTime.ToString();
        txtDeliveryAddress.Text = Order.ThisOrder.DeliveryAddress;
        txtNotes.Text = Order.ThisOrder.Notes;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string Notes = txtNotes.Text;

        string PhoneNumber = txtPhoneNumber.Text;

        string ItemQuantity = txtItemQuantity.Text;

        string DeliveryTime = txtDeliveryTime.Text;

        string DeliveryAddress = txtDeliveryAddress.Text;

        string Error = "";

        Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

        if(Error == "")
        {
            AnOrder.OrderID = OrderID;

            AnOrder.PhoneNumber = Convert.ToInt64(PhoneNumber);

            AnOrder.ItemQuantity = Convert.ToInt32(ItemQuantity);

            AnOrder.Delivery = chkDelivered.Checked;

            DateTime Date = Convert.ToDateTime(DeliveryTime);

            AnOrder.DeliveryTime = Date;

            AnOrder.DeliveryAddress = DeliveryAddress;

            AnOrder.Notes = Notes;

            clsOrderCollection OrderList = new clsOrderCollection();

            if(OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;

                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);

                OrderList.ThisOrder = AnOrder;

                OrderList.Update();
            }

            //redirect back to the lispage
            Response.Redirect("OrderList.aspx");
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