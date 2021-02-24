<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1ServicesAdd.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblServiceName" runat="server" style="z-index: 1; left: 6px; top: 34px; position: absolute; height: 53px; right: 880px" Text="Service"></asp:Label>
        <asp:TextBox ID="txtServiceName" runat="server" style="z-index: 1; left: 61px; top: 33px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 9px; top: 58px; position: absolute" Text="Stylist" width="128px"></asp:Label>
        <asp:TextBox ID="txtStaff" runat="server" style="z-index: 1; left: 62px; top: 57px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 92px; position: absolute" Text="Price" width="128px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 52px; top: 90px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDuration" runat="server" style="z-index: 1; left: 12px; top: 126px; position: absolute" Text="Duration" width="128px"></asp:Label>
        <asp:TextBox ID="txtDuration" runat="server" style="z-index: 1; left: 74px; top: 123px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkDiscount" runat="server" style="z-index: 1; left: 9px; top: 160px; position: absolute" Text="Discount" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 204px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 11px; top: 240px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 55px; top: 239px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="lblServiceName0" runat="server" style="z-index: 1; left: 6px; top: 34px; position: absolute; height: 53px" Text="Service" width="128px"></asp:Label>
        </p>
    </form>
</body>
</html>
