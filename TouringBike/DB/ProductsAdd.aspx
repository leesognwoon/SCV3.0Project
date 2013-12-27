<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsAdd.aspx.cs" Inherits="TouringBike.DB.ProductsAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Touring 자전거 상품 추가<br />
        <table border = "1">

        <tr>
        <td>상품명:</td>
        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>상품코드:</td>
        <td><asp:TextBox ID="txtNumber" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>표준원가:</td>
        <td><asp:TextBox ID="txtCost" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>판매가격:</td>
        <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>판매시작일:</td>
        <td><asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
        </tr>
        </table>
        </div>
    <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" 
        style="height: 21px" Text="추가" />
    </form>
</body>
</html>
