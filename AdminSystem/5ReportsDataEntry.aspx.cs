using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{


    Int32 EmployeeId;

    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the address to be processed
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (EmployeeId != -1)
            {
                //display the current data for the record
                DisplayReport();
            }
        }
    }

    private void DisplayReport()
    {
        clsReportsCollection ReportsEmployeeId = new clsReportsCollection();

        //find the record to update
        ReportsEmployeeId.ThisReport.Find(EmployeeId);

        //display the data for this record
        txtEmployeeId.Text = ReportsEmployeeId.ThisReport.EmployeeId.ToString();
        txtEmployeeName.Text = ReportsEmployeeId.ThisReport.EmployeeName;
        txtTotal.Text = ReportsEmployeeId.ThisReport.Total.ToString();
        txtDateAdded.Text = ReportsEmployeeId.ThisReport.DateAdded.ToString();
        txtExpenses.Text = ReportsEmployeeId.ThisReport.Expenses.ToString();
        chkProfit.Checked = ReportsEmployeeId.ThisReport.ProfitOrLoss;
        chkLoss.Checked = ReportsEmployeeId.ThisReport.ProfitOrLoss;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReports AReport = new clsReports();

        

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
        Error = AReport.Valid(EmployeeName, Total, Expenses, DateAdded);
        if (Error == "")
        {

            //Capture the employee id
            AReport.EmployeeId = EmployeeId;
            
            //Capture EmployeeName
            AReport.EmployeeName = EmployeeName;
            //capture DateAdded
            AReport.DateAdded = Convert.ToDateTime(DateAdded);
            //capture Total
            AReport.Total = Convert.ToInt32(Total);
            //capture Expenses
            AReport.Expenses = Convert.ToInt32(Expenses);
            //capture Profit
            AReport.ProfitOrLoss = chkProfit.Checked;
            //capture Loss
            AReport.ProfitOrLoss = chkLoss.Checked;

            //create a new instance of the reports collection
            clsReportsCollection ReportList = new clsReportsCollection();

            //if this is a new record i.e. EmployeeId = -1 then add the data
            if (EmployeeId == -1)
            {
                //set the ThisReport property
                ReportList.ThisReport = AReport;

                //add the new record
                ReportList.Add();
            }
            else
            {
                //find the record to update
                ReportList.ThisReport.Find(EmployeeId);

                //set the ThisReport property
                ReportList.ThisReport = AReport;

                //update the record
                ReportList.Update();
            }

           
            //redirect back to the listpage
            Response.Redirect("5ReportsList.aspx");
            
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("5ReportsDataEntry.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("5ReportsList.aspx");
    }

    protected void chkLoss_CheckedChanged(object sender, EventArgs e)
    {

    }
}