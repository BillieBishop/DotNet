<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTrip.aspx.cs" Inherits="TripPlanner.ViewTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Form view (to fix):
        <br />
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource">
            <EditItemTemplate>
                Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:TextBox ID="fullNameTextBox" runat="server" Text='<%# Bind("fullName") %>' />
                <br />
                gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                passportNumber:
                <asp:TextBox ID="passportNumberTextBox" runat="server" Text='<%# Bind("passportNumber") %>' />
                <br />
                date:
                <asp:TextBox ID="dateTextBox" runat="server" Text='<%# Bind("date") %>' />
                <br />
                departureAirport:
                <asp:TextBox ID="departureAirportTextBox" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:TextBox ID="arrivalAirportTextBox" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                fullName:
                <asp:TextBox ID="fullNameTextBox" runat="server" Text='<%# Bind("fullName") %>' />
                <br />
                gender:
                <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                passportNumber:
                <asp:TextBox ID="passportNumberTextBox" runat="server" Text='<%# Bind("passportNumber") %>' />
                <br />
                date:
                <asp:TextBox ID="dateTextBox" runat="server" Text='<%# Bind("date") %>' />
                <br />
                departureAirport:
                <asp:TextBox ID="departureAirportTextBox" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:TextBox ID="arrivalAirportTextBox" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:Label ID="fullNameLabel" runat="server" Text='<%# Bind("fullName") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Bind("gender") %>' />
                <br />
                passportNumber:
                <asp:Label ID="passportNumberLabel" runat="server" Text='<%# Bind("passportNumber") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Bind("date") %>' />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Bind("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Bind("arrivalAirport") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Trips]"></asp:SqlDataSource>
        <br />
        DataList:<asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                Id:
                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                fullName:
                <asp:Label ID="fullNameLabel" runat="server" Text='<%# Eval("fullName") %>' />
                <br />
                gender:
                <asp:Label ID="genderLabel" runat="server" Text='<%# Eval("gender") %>' />
                <br />
                passportNumber:
                <asp:Label ID="passportNumberLabel" runat="server" Text='<%# Eval("passportNumber") %>' />
                <br />
                date:
                <asp:Label ID="dateLabel" runat="server" Text='<%# Eval("date", "{0:d}") %>' />
                <br />
                departureAirport:
                <asp:Label ID="departureAirportLabel" runat="server" Text='<%# Eval("departureAirport") %>' />
                <br />
                arrivalAirport:
                <asp:Label ID="arrivalAirportLabel" runat="server" Text='<%# Eval("arrivalAirport") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Trips] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
