using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteReport : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 EmployeeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        

        //get the number of the report to be deleted from the session object
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book
        clsReportsCollection ReportBook = new clsReportsCollection();

        //find the record to delete
        ReportBook.ThisReport.Find(EmployeeId);

        //delete the record
        ReportBook.Delete();

        //redirect back to the main page
        Response.Redirect("5ReportsList.aspx");
    }
}