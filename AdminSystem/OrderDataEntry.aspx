<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="OrderID" runat="server" Text="Order number" width="86px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 27px" width="86px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivered" width="86px" />
        </p>
        <asp:Label ID="lblError" runat="server" width="86px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" width="86px" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 28px" Text="Cancel" width="86px" />
        </p>
    </form>
</body>
</html>
