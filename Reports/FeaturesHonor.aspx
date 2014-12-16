<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FeaturesHonor.aspx.cs" Inherits="Reports_FeaturesHonor" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">





                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
    DataSourceID="SqlDataSourceFH" DataTextField="name" DataValueField="char_id" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">select all</asp:ListItem>
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSourceFH" runat="server" 
    ConnectionString="<%$ ConnectionStrings:D:\MYWORK\AZHAR.MDFConnectionString %>" 
    SelectCommand="SELECT [char_id], [name] FROM [characters_details]">
</asp:SqlDataSource>





                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote" style="margin-top: 55px" 
                    InternalBorderStyle="Double">
                    <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
                </rsweb:ReportViewer>
                




</asp:Content>

