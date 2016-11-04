<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TripPlanner.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource">
            <Columns>
               <asp:TemplateField HeaderText="#">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/ViewTrip.aspx?ID={0}" DataTextField="fullName" HeaderText="Name" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="False" />
                <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
                <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" DataFormatString="{0:dd-MMMM-yyyy}"/>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [Id], [fullName], [gender], [date] FROM [Trips]"
            OnSelected="SqlDataSource_Selected"
            >            
        </asp:SqlDataSource>    
        <br />
        <asp:Label ID="lblTripCount" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
