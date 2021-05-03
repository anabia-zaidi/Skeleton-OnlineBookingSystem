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
}