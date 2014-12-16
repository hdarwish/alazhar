<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Keywords.aspx.cs" Inherits="Reports_Keywords" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server" 
    DataSourceID="SqlDataSourceKeywords" DataTextField="title" DataValueField="id" 
        AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSourceKeywords" runat="server" 
    ConnectionString="<%$ ConnectionStrings:D:\MYWORK\AZHAR.MDFConnectionString2 %>" 
    SelectCommand="SELECT [title], [id] FROM [content_types]">
</asp:SqlDataSource>
<rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="96%" 
                    ProcessingMode="Remote" style="margin-top: 82px">
    <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
</rsweb:ReportViewer>
</asp:Content>

