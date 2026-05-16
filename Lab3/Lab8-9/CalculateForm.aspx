<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateForm.aspx.cs" Inherits="FirstWebApp.CalculateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiplication</title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Web Server Control</legend>
            
            <asp:Label ID="labl1" runat="server" Text="Enter First Number: " />
            <asp:TextBox ID="fnum" runat="server"/>
            <br />

            <asp:Label ID="labl2" runat="server" Text="Enter Second Number: " />
            <asp:TextBox ID="snum" runat="server" />
            <br />
                
            <asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" />
            <br />

            <asp:Label ID="result" runat="server" />
        </fieldset>

    </form>
</body>
</html>
