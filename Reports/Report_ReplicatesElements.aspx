<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Report_ReplicatesElements.aspx.cs" Inherits="Reports_Report_ReplicatesElements" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style2
        {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td colspan="2" class="style2">
            <strong>تقرير مكررات العناصر</strong></td>
    </tr>
    <tr>
        <td style="text-align: right">
            <asp:DropDownList ID="object_type" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="title" DataValueField="id" 
                onselectedindexchanged="object_type_SelectedIndexChanged" 
                AutoPostBack="True">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:C:\USERS\AMR\DESKTOP\AZHAR\DB\AZHAR.MDFConnectionString %>" 
                SelectCommand="SELECT [id], [title] FROM [content_types]">
            </asp:SqlDataSource>
        </td>
        <td>
            نوع العنصر</td>
    </tr>
    <tr>
        <td colspan="2">
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%">
            </rsweb:ReportViewer>
        </td>
    </tr>
</table>
</asp:Content>

