<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetCustomer.aspx.cs" Inherits="CalculatorWebApplication.GetCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetCustomer() {
            var id = document.getElementById("txtId").value;
            WebServicesDemo.CustomerWebService.GetCustomerById(id, GetCustomerByIdSucessCallback, GetCustomerByIdFailCallback);
        }

        function GetCustomerByIdSucessCallback(result) {
            document.getElementById("txtFirstName").value = result["FirstName"];
            document.getElementById("txtLastName").value = result["LastName"];
            document.getElementById("txtAge").value = result["Age"];
            document.getElementById("txtCreateDate").value = result["CreateDate"];
        }

        function GetCustomerByIdFailCallback(error) {
            alert(error.get_message());
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/CustomerWebService.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <input type="button" value="Get Customer" onclick="GetCustomer()" />
            <br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtCreateDate" runat="server"></asp:TextBox>

            <br />
            Time below does not change=> partial postback on page happens when using AJAX for web services
            <asp:Label ID="lblTime" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
