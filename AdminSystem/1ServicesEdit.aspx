<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1ServicesEdit.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblServiceName" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Service"></asp:Label>
        </div>
        <asp:TextBox ID="txtServiceName" runat="server" style="z-index: 1; left: 69px; top: 14px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 13px; top: 51px; position: absolute" Text="Staff"></asp:Label>
        <asp:TextBox ID="txtStaff" runat="server" style="z-index: 1; left: 71px; top: 49px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 82px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 68px; top: 85px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDuration" runat="server" style="z-index: 1; left: 15px; top: 115px; position: absolute" Text="Duration"></asp:Label>
        <asp:TextBox ID="txtDuration" runat="server" style="z-index: 1; left: 76px; top: 115px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkDiscount" runat="server" style="z-index: 1; left: 20px; top: 155px; position: absolute" Text="Discount" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 196px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 233px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 68px; top: 231px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
