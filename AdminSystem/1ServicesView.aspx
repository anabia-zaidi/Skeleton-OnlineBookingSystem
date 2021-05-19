<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1ServicesView.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 393px; top: 183px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstServiceList" runat="server" OnSelectedIndexChanged="lstServiceList_SelectedIndexChanged" style="z-index: 1; left: 21px; top: 21px; position: absolute; height: 291px; width: 355px"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 391px; top: 50px; position: absolute; height: 1px; width: 436px" Text="Enter Staff "></asp:Label>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 457px; top: 110px; position: absolute; height: 35px" Text="Clear" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 399px; top: 110px; position: absolute; height: 36px; width: 43px" Text="Apply" />
        </p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 395px; top: 74px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 466px; top: 183px; position: absolute" Text="Edit" />
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 540px; top: 184px; position: absolute" Text="Delete" />
        <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 396px; top: 237px; position: absolute" Text="Return to Main Page" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 395px; top: 275px; position: absolute; height: 4px; width: 382px" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
