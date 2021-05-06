<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5ReportsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void lstReportsList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstReportsList" runat="server" Height="315px" OnSelectedIndexChanged="lstReportsList_SelectedIndexChanged" Width="316px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" Text="Delete" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblEnterEmployeeName" runat="server" Text="Enter Employee Name: "></asp:Label>
            <br />
            <asp:TextBox ID="txtEmployeeName" runat="server" OnTextChanged="TextBox1_TextChanged" Width="229px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="Button2_Click" Text="Clear" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
