<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btnAdd_Click"/>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="gvResult" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
