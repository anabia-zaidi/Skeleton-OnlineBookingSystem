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
        string ServiceName = txtServiceName.Text;
       
        string Staff = txtStaff.Text;
        
        string Price = txtPrice.Text;
       
        string Duration = txtDuration.Text;


        string Error = "";
        //validate the data
        Error = AService.Valid(ServiceName, Staff, Price, Duration);
        if (Error == "")
        {

           
            AService.ServiceName = ServiceName;

            
            AService.Staff = Staff;

            AService.Price = Convert.ToInt32(Price);

            AService.Duration = Convert.ToInt32(Duration);

            Session["AService"] = AService;

            Response.Write("1ServicesView.aspx");

        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

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