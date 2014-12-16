<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master"
    AutoEventWireup="true" CodeFile="Report_References.aspx.cs" Inherits="Reports_Report_References" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style1">
        <tr>
            <td class="style2" colspan="2">
                <strong>تقرير المراجع التى تم ادخالها</strong>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:DropDownList ID="object_type" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged"
                    DataSourceID="SqlDataSource1">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:C:\USERS\AMR\DESKTOP\AZHAR\DB\AZHAR.MDFConnectionString %>"
                    SelectCommand="SELECT [id], [title] FROM [content_types]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="نوع الاستمارة" ForeColor="#996633" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: right">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ProcessingMode="Remote">
                    <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
                </rsweb:ReportViewer>
            </td>
        </tr>
    </table>
</asp:Content>
