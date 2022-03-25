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
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //Capture the Order Number
        AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //Navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}