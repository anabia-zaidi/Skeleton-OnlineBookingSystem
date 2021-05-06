using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayReports();
        }
    }

    void DisplayReports()
    {
        clsReportsCollection Reports = new clsReportsCollection();

        //set the data source to the list of Employees in the collection
        lstReportsList.DataSource = Reports.ReportList;

        //set the name of the primary key
        lstReportsList.DataValueField = "EmployeeId";

        //set the data field to display
        lstReportsList.DataTextField = "EmployeeName";

        //bind the data to the list
        lstReportsList.DataBind();


    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store the -1 the session object to indicate this is a new record
        Session["EmployeeId"] = -1;

        //redirect to the data entry page
        Response.Redirect("5ReportsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeId;

        //if the record has been selected from the list
        if (lstReportsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            EmployeeId = Convert.ToInt32(lstReportsList.SelectedValue);

            //store the data in the session object
            Session["EmployeeId"] = EmployeeId;

            //redirect to the edit page
            Response.Redirect("5ReportsDataEntry.aspx");   //double check if its the correct apsx
        }
        else //if not record has been selected
        {
            //Display an error
                lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value  of the record to be deleted
        Int32 EmployeeId;

        //if the record has been selected from the list
        if(lstReportsList.SelectedIndex != -1)
        {
            //get the primary key value fo the record to delete
            EmployeeId = Convert.ToInt32(lstReportsList.SelectedValue);

            //store the data in the session object
            Session["EmployeeId"] = EmployeeId;

            //redirect to the delete page
            Response.Redirect("DeleteReport.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void txtEmployeeName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsReportsCollection Reports = new clsReportsCollection();
        Reports.ReportByEmployeeName("");

        //clear any existing filter to tidy up the interface
        txtEmployeeName.Text = "";
        lstReportsList.DataSource = Reports.ReportList;

        //set the name of the primary key
        lstReportsList.DataValueField = "EmployeeId";

        //set the name of the field to display
        lstReportsList.DataTextField = "EmployeeName";

        //bind the data to the list
        lstReportsList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the class collection
        clsReportsCollection Reports = new clsReportsCollection();
        Reports.ReportByEmployeeName(txtEmployeeName.Text);
        lstReportsList.DataSource = Reports.ReportList;

        //set the name of the primary key
        lstReportsList.DataValueField = "EmployeeId";

        //set the name of the field to display
        lstReportsList.DataTextField = "EmployeeName";

        //bind the data to the list
        lstReportsList.DataBind();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}