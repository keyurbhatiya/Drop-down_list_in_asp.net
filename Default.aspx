<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 48px">
        <strong>SELECT ANY NAME :</strong> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="164px" BackColor="#FF9900" ForeColor="Black" style="font-weight: 700"></asp:DropDownList>
    
    </div>
       <center> <asp:Image ID="Image1" runat="server" Height="566px" Width="1282px"/></center>
    </form>
</body>
</html>
