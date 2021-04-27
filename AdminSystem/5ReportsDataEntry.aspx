<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5ReportsDataEntry.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id"></asp:Label>
            <asp:TextBox ID="txtEmployeeId" runat="server" OnTextChanged="TextBox1_TextChanged" Width="113px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblEmployeeName" runat="server" Text="Employee Name: " width="77px"></asp:Label>
            <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblExpenses" runat="server" Text="Expenses" width="77px"></asp:Label>
        <asp:TextBox ID="txtExpenses" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblTotal" runat="server" Text="Total" width="77px"></asp:Label>
        <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkProfit" runat="server" Text="Profit" width="77px" />
        <asp:CheckBox ID="chkLoss" runat="server" Text="Loss" width="77px" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="height: 26px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
