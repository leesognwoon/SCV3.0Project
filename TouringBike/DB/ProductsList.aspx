<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="TouringBike.DB.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Touring 자전거 상품 관리<br />
        <table border="1" width="100%">
            <asp:Repeater ID="rptProducts" runat="server" 
                onitemcommand="rptProducts_ItemCommand">
                <HeaderTemplate>
                    <tr>
                        <th>
                            상품번호
                        </th>
                        <th>
                            상품명
                        </th>
                        <th>
                            상품코드
                        </th>
                        <th>
                            표준원가
                        </th>
                        <th>
                            판매가격
                        </th>
                        <th>
                            판매시작일
                        </th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Eval("ID") %>
                        </td>
                        <td>
                            <%# Eval("Name") %>
                        </td>
                        <td>
                            <%# Eval("Number") %>
                        </td>
                        <td>
                            <%# Eval("Cost") %>
                        </td>
                        <td>
                            <%# Eval("Price") %>
                        </td>
                        <td>
                            <%# Eval("SSdate") %>
                        </td>
                        <td>
                        <asp:Button ID="btnUpdate" CommandName = "Update" CommandArgument= '<%# Eval("ID") %>' runat="server" Text="수정" />
                        <asp:Button ID="btnDelete" CommandName = "Delete"  CommandArgument= '<%# Eval("ID") %>' runat="server" Text="삭제" />
                        </td>
                    </tr>
                    
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="~/DB/ProductsAdd.aspx">상품추가</asp:HyperLink>
    </form>
</body>
</html>
