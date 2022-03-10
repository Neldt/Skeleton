﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="OrderID" runat="server" Text="Order number" width="198px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 27px" width="198px"></asp:TextBox>
        <p>
            <asp:Label ID="OrderCode" runat="server" Text="OrderCode" width="198px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" width="198px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="ItemQuantity" runat="server" Text="Number of Item(s)" width="198px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox" runat="server" width="198px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="PurchaseTime" runat="server" Text="Time of the purchase" width="198px"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" width="198px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivered" width="198px" />
        </p>
        <p>
            <asp:Label ID="deliveryAddress" runat="server" Text="Address to drop off" width="198px"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" width="198px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Notes" runat="server" Text="Any Instruction. (please specify)."></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" width="198px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" width="198px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" width="86px" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 28px" Text="Cancel" width="86px" />
        </p>
    </form>
</body>
</html>
