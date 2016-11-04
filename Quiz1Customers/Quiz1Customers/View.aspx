<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Quiz1Customers.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View</title>    
</head>
<body>
    <br />    
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' />
                <br />
                Province:
                <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>    
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringDB %>" SelectCommand="SELECT * FROM [Customers] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
