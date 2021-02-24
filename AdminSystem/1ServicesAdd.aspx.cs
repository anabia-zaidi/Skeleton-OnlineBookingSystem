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
        clsServices AService = new clsServices();
        AService.Staff = txtStaff.Text;
        Session["A Service"] = AService;
        Response.Redirect("1ServicesView.aspx");
    }
}