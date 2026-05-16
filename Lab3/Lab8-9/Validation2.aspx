<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation2.aspx.cs" Inherits="FirstWebApp.Validation2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Valitdation Server Control</legend>

            <asp:Label ID="l1" runat="server" Text="Name: " /><br />
            <asp:TextBox ID="txtname" runat="server" />
            <asp:RequiredFieldValidator ID="rf1" runat="server" ControlToValidate="txtname" ErrorMessage="Name is required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="rg1" runat="server" ControlToValidate="txtname" ErrorMessage="Invalid Name" ForeColor="Red" ValidationExpression="^[a-zA-Z ]+$" />
            <br /><br />

            <asp:Label ID="l2" runat="server" Text="E-mail: " /><br />
            <asp:TextBox ID="txtemail" runat="server" />
            <asp:RequiredFieldValidator ID="rf2" runat="server" ErrorMessage="E-mail is required" ControlToValidate="txtemail" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="rg2" runat="server" ControlToValidate="txtemail" ErrorMessage="Invalid E-mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            <br /><br />

            <asp:Label ID="l3" runat="server" Text="Password: " /><br />
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rf3" runat="server" ControlToValidate="txtpass" ErrorMessage="Password is required" ForeColor="Red" />
            <asp:CustomValidator ID="cv1" runat="server" ControlToValidate="txtpass" ErrorMessage="Password length must be more than 5" ForeColor="Red" ValidateEmptyText="true" OnServerValidate="cv1_ServerValidate" />
            <br /><br />

            <asp:Label ID="l4" runat="server" Text="Re-Type Password: " /><br />
            <asp:TextBox ID="repass" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rf4" runat="server" ControlToValidate="repass" ErrorMessage="Re-Type password is required" ForeColor="Red" />
            <asp:CompareValidator ID="cmp" runat="server" ControlToValidate="repass" ErrorMessage="Password does not match" ForeColor="Red" ControlToCompare="txtpass" />
            <br /><br />

            <asp:Label ID="l5" runat="server" Text="Age: " /><br />
            <asp:TextBox ID="txtage" runat="server" />
            <asp:RequiredFieldValidator ID="rf5" runat="server" ControlToValidate="txtage" ErrorMessage="Age is required." ForeColor="Red" /><br />
            <asp:RangeValidator ID="r1" runat="server" ControlToValidate="txtage" ErrorMessage="Age must be between 18 - 60" ForeColor="Red" MinimumValue="18" MaximumValue="60" />
            <br /><br />

            <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSub_Click"/><br /><br />

            <asp:ValidationSummary ID="vsumm" runat="server" ForeColor="Red"/><br />
            <asp:Literal ID="details" runat="server" />

        </fieldset>
    </form>
</body>
</html>
