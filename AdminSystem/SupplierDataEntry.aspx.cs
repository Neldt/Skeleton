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
        clsSupplier AnSupplier = new clsSupplier();
        AnSupplier.SupplierProduct = txtSupplierProduct.Text;
        Session["AnSupplier"] = AnSupplier;
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        Int32 SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
        Found = AnSupplier.Find(SupplierId);
        if (Found == true)
        {
            txtSupplierId.Text = AnSupplier.SupplierId.ToString();
            txtSupplierFeedback.Text = AnSupplier.SupplierFeedback.ToString();
            txtSupplierPrice.Text = AnSupplier.Price.ToString();
            txtSupplierProduct.Text = AnSupplier.SupplierProduct;
            txtDeliveryDate.Text = AnSupplier.DeliveryDate.ToString();
            






        }
    }
}