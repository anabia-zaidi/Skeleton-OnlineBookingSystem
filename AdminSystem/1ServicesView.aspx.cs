using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    private readonly object txtStaff;
    private object lblError;

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayServices();
        }
    }

    void DisplayServices()
    {
        clsServicesCollection Reports = new clsServicesCollection();

        lstServiceList.DataSource = Reports.ServiceList;

        //set the name of the primary key
        lstServiceList.DataValueField = "Service Name";

        //set the data field to display
        lstServiceList.DataTextField = "Staff";

        //bind the data to the list
        lstServiceList.DataBind();


    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store the -1 the session object to indicate this is a new record
        Session["Service Name"] = -1;

        //redirect to the data entry page
        Response.Redirect("1ServicesAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
       string ServiceName;

        
        if (lstServiceList.SelectedIndex != -1)
        {
           
            ServiceName = Convert.ToString(lstServiceList.SelectedValue);

            
            Session["ServiceName"] = ServiceName;

            //redirect to the edit page
            Response.Redirect("1ServicesEdit.aspx");
        }
        else //if not record has been selected
        {
            //Display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
       
        string ServiceName;

       
        if (lstServiceList.SelectedIndex != -1)
        {
            
            ServiceName = Convert.ToString(lstServiceList.SelectedValue);

            
            Session["ServiceName"] = ServiceName;

            //redirect to the delete page
            Response.Redirect("5ServiceDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e) //Delete Button Code - btnDelete
    {
       
        string ServiceName;

       
        if (lstServiceList.SelectedIndex != -1)
        {
            
            ServiceName = Convert.ToString(lstServiceList.SelectedValue);


            Session["ServiceName"] = ServiceName;

            //redirect to the delete page
            Response.Redirect("1ServiceDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void txtServiceName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsServicesCollection Services = new clsServicesCollection();
        Services.ServiceByStaff("");

        //clear any existing filter to tidy up the interface
        txtStaff.Text = "";
        lstServiceList.DataSource = Services.ServiceList;

        //set the name of the primary key
        lstServiceList.DataValueField = "Service Name";

        //set the name of the field to display
        lstServiceList.DataTextField = "Staff";

        //bind the data to the list
        lstServiceList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the class collection
        clsServicesCollection Services = new clsServicesCollection();
        Services.ServiceByStaff(txtStaff.Text);
        lstServiceList.DataSource = Services.ServiceList;

        //set the name of the primary key
        lstServiceList.DataValueField = "Service Name";

        //set the name of the field to display
        lstServiceList.DataTextField = "Staff";

        //bind the data to the list
        lstServiceList.DataBind();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("1ServiceView.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("1ServiceAdd.aspx");
    }

    protected void lstServiceList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}