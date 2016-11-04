<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTrip.aspx.cs" Inherits="TripPlanner.NewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Full Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxFullName" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        <br />
        Gender :
        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="Null">N/A</asp:ListItem>
            <asp:ListItem Value="M">M</asp:ListItem>
            <asp:ListItem Value="F">F</asp:ListItem>
        </asp:RadioButtonList>
        Passport number :&nbsp;
        <asp:TextBox ID="tbxPassport" runat="server"></asp:TextBox>
        <br />
        Date :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbxDate" TextMode="Date" runat="server"></asp:TextBox>
    
        <br />
        Departure Airport :<asp:DropDownList ID="airportFromList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode" Width="132px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        Arrival Airport :&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="airportToList" runat="server" DataSourceID="SqlDataSource" DataTextField="airportName" DataValueField="airportCode" Width="132px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT code AS airportCode, (code + ' - ' + name) AS airportName FROM [Airports]"></asp:SqlDataSource>
    
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Trip" />
    
    </div>
    </form>
</body>
</html>
