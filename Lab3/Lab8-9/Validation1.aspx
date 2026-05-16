<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation1.aspx.cs" Inherits="FirstWebApp.Validation1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Validation Controls</legend>

            <asp:Label ID="l1" runat="server" Text="Roll: "/><br />
            <asp:TextBox ID="txtroll" runat="server" />
            <asp:RangeValidator ID="r1" runat="server" ControlToValidate="txtroll" ErrorMessage="Roll must be between 1 - 70" ForeColor="Red" MinimumValue="1" MaximumValue="70" />
            <br /><br />

            <asp:Label ID="l2" runat="server" Text="Name: " /><br />
            <asp:TextBox ID="txtname" runat="server" />
            <asp:RequiredFieldValidator ID="rq1" runat="server" ControlToValidate="txtname" ErrorMessage="Name is required" ForeColor="Red"/>
            <asp:RegularExpressionValidator ID="rg1" runat="server" ControlToValidate="txtname" ErrorMessage="Invalid Name" ForeColor="Red" ValidationExpression="^[a-zA-z ]+$" /> 
            <br /><br />

            <asp:Label ID="l3" runat="server" Text="Semester: " /><br />
            <asp:TextBox ID="txtsem" runat="server" />
            <asp:RequiredFieldValidator ID="rq2" runat="server" ControlToValidate="txtsem" ErrorMessage="Semester is required" ForeColor="Red"/>
            <asp:RegularExpressionValidator ID="rg2" runat="server" ControlToValidate="txtsem" ErrorMessage="Invalid Semester" ForeColor="Red" ValidationExpression="^[1-8]$" />
            <br /><br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" CausesValidation="true" OnClick="btnInsert_Click"/>
            <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" /><br />

            <asp:Literal ID="details" runat="server" />
        </fieldset>
    </form>
</body>
</html>
