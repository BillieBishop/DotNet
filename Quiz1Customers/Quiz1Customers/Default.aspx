<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Quiz1Customers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
<style>
        .rightText{
            text-align:right;
        }
    </style>
</head>
<body>
    <br />
    <div class="rightText">
        <a href="/Add.aspx">Add a new Customer</a>
    </div>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomersGender" runat="server"></asp:Label>      

        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDS">
                <Columns>
                    <asp:TemplateField HeaderText="#"></asp:TemplateField>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/View.aspx?ID={0}" DataTextField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringDB %>" SelectCommand="SELECT [Gender], [Name] FROM [Customers] WHERE ([Id] = @Id)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="Id" QueryStringField="ID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
