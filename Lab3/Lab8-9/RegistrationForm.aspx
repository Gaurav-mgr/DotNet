<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="FirstWebApp.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Registration Form</legend>
            <asp:Label ID="l1" runat="server" Text="Roll: "/>
            <asp:TextBox ID="txtroll" runat="server"/><br /><br />

            <asp:Label ID="l2" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txtname" runat="server"/><br /><br />

            <asp:Label ID="l3" runat="server" Text="E-mail: "></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"/><br /><br />

            <asp:Label ID="l4" runat="server" Text="Gender: "/>
            <asp:RadioButton ID="male" runat="server" GroupName="gender" Text="Male" Checked="true"/>
            <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="Female"/><br /><br />
            
            <asp:Label ID="l5" runat="server" Text="Program: " />
            <asp:CheckBox ID="bca" runat="server" Text="BCA" />
            <asp:CheckBox ID="bsc" runat="server" Text="BSC" />
            <asp:CheckBox ID="bscsit" runat="server" Text="BSCSIT" /><br /><br />

            <asp:Label ID="l6" runat="server" Text="Shift: " />
            <asp:DropDownList ID="ddlist" runat="server">
                <asp:ListItem Text="Morning" Value="Morning" />
                <asp:ListItem Text="Afternoon" Value="Afternoon" />
            </asp:DropDownList><br /><br />

            <asp:Button ID="btn" runat="server" Text="Send" OnClick="btn_Click" />
        </fieldset>
    </form>
</body>
</html>
