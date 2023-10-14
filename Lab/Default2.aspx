<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>CURD Operation Using Form</h1>
        <div>
            <asp:GridView ID="gvPhoneBook" runat="server" AutoGenerateColumns="False" BackColor="White" ShowFooter="True" ShowHeaderWhenEmpty="True" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="SqlDataSource1" GridLines="Horizontal">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle ForeColor="#333333" BackColor="White" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />

                <Columns>
                    <asp:BoundField DataField="PhoneBookId" HeaderText="PhoneBookId" SortExpression="PhoneBookId" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />



                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RajeevConnectionString %>" ProviderName="<%$ ConnectionStrings:RajeevConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [PhoneBook] order by (FirstName)"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
