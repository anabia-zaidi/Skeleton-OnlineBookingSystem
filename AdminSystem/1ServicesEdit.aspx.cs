using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object txtDiscount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsServices AService = new clsServices();
        AService.ServiceName = txtServiceName.Text;
        Session["AService"] = AService;
        Response.Redirect("1ServicesView.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsServices AService = new clsServices();
       String ServiceName;
        Boolean Found = false;
        ServiceName = Convert.ToString(txtServiceName.Text);
        Found = AService.Find(ServiceName);
        if (Found == true)
        {
            txtServiceName.Text = AService.ServiceName;
            txtStaff.Text = AService.Staff;
            txtPrice.Text = AService.Price.ToString();
            txtDuration.Text = AService.Duration.ToString();
          

        }
    }
}