<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Quiz1Customers.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add a new customer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server"
            ControlToValidate="tbxName" ForeColor="Red"
            ErrorMessage="You must enter your name."></asp:RequiredFieldValidator>
        &nbsp;
        <asp:RegularExpressionValidator ID="NameRegularExpressionValidator" runat="server"
            ControlToValidate="tbxName" ForeColor="Red"
            ErrorMessage="You can only use letters. Space, hyphen and dot are accepted."
            ValidationExpression="^[A-Za-z -.]{2,}$"></asp:RegularExpressionValidator>
        <br />

        Postal Code :
        <asp:TextBox ID="tbxPostalCode" runat="server"></asp:TextBox>
        &nbsp;        
        <asp:RegularExpressionValidator ID="PostalCodeRegularExpressionValidator" runat="server"
            ControlToValidate="tbxPostalCode" ForeColor="Red"
            ErrorMessage="Postal code should look like A1A1A1"
            ValidationExpression="^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$"></asp:RegularExpressionValidator>
        <br />

        Province :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlProvince" runat="server" 
            DataSourceID="SqlDS" DataTextField="provinceFull" DataValueField="Code">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDS" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT Code, (Code + ' - ' + name) AS provinceFull FROM [Provinces]"></asp:SqlDataSource>
        <asp:RequiredFieldValidator ID="ProvinceRequiredFieldValidator" runat="server"
            ControlToValidate="ddlProvince" ForeColor="Red"
            ErrorMessage="You must select a province."></asp:RequiredFieldValidator>
        <br />

        Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server"
            ControlToValidate="tbxEmail" ForeColor="Red"
            ErrorMessage="You must enter your email."></asp:RequiredFieldValidator>
        &nbsp;
        <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server"
            ControlToValidate="tbxEmail" ForeColor="Red"
            ErrorMessage="RegularExpressionValidator"
            ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
        <br />

        Gender :
        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="Null">N/A</asp:ListItem>
            <asp:ListItem Value="M">Male</asp:ListItem>
            <asp:ListItem Value="F">Female</asp:ListItem>
        </asp:RadioButtonList>        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringDB %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click" />
        <br />          
    </div>
    </form>
</body>
</html>
