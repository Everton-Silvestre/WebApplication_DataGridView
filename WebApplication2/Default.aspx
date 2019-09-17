<%@ Page Title="Home Page Teste" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView    ID="GridView1"        runat="server" AllowUserToAddRows="false"    AutoGenerateColumns="false"                  AllowPaging="false"            OnPageIndexChanging="OnPageIndexChanging" >
            <pagersettings mode="NextPrevious"/>
     <%--   <pagerstyle 
          height="20px"
          verticalalign="Bottom"
          horizontalalign="right"/>--%>
    <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="CustomerID" HeaderText="Customer ID" />
        <asp:BoundField ItemStyle-Width="150px" DataField="ContactName" HeaderText="Contact Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="City" HeaderText="City" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Country" HeaderText="Country" />
    </Columns> 


</asp:GridView>

<asp:Button id="Button1"
           Text="Sort Ascending"
           CommandName="Sort"
           CommandArgument="Ascending"
           OnCommand="CommandBtn_Click" 
           runat="server"/>

    <asp:Button id="Button2"
           Text="Sort Ascending"
           CommandName="Sort"
           CommandArgument="Ascending"
           OnCommand="CommandBtn2_Click" 
           runat="server"/>

<asp:TextBox ID="Value2" Columns="2" MaxLength="50" runat="server" />
    <asp:TextBox ID="Value3" Columns="2" MaxLength="50" runat="server" />
</asp:Content>


