using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
  

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReports AReport = new clsReports();

        //capture employeeid
        string EmployeeId = txtEmployeeId.Text;
        //capture employeeName
        string EmployeeName = txtEmployeeName.Text;
        //capture DateAdded
        string DateAdded = txtDateAdded.Text;
        //capture Total
        string Total = txtTotal.Text;
        //capture Expenses
        string Expenses = txtExpenses.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AReport.Valid(EmployeeId, EmployeeName, Total, Expenses, DateAdded);
        if (Error == "")
        {
            //Capture EmployeeId
            AReport.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            //Capture EmployeeName
            AReport.EmployeeName = Convert.ToString(txtEmployeeName.Text);
            //capture DateAdded
            AReport.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //capture Total
            AReport.Total = Convert.ToInt32(txtTotal.Text);
            //capture Expenses
            AReport.Expenses = Convert.ToInt32(txtExpenses.Text);
            //store the address in the session object
            Session["AReport"] = AReport;
            //navigate to viewer page
            Response.Redirect("5ReportsViewer.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsReports AReport = new clsReports();

        //variable to store the primary key
        Int32 EmployeeId;

        //variable to store result of the find operation
        Boolean Found = false;

        //get primary key enterd by the user
        EmployeeId = Convert.ToInt32(txtEmployeeId.Text);

        //find the record
        Found = AReport.Find(EmployeeId);

        //if found
        if (Found == true)
        {
            //Display the values of the properties in form
            txtEmployeeId.Text = AReport.EmployeeId.ToString();
            txtEmployeeName.Text = AReport.EmployeeName;
            txtExpenses.Text = AReport.Expenses.ToString();
            txtTotal.Text = AReport.Total.ToString();
        }
}
}