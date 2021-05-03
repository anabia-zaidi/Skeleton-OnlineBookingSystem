<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6List.aspx.cs" Inherits="_1_List" %>

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
        </div>
    </form>
</body>
</html>
