<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DetailedReportOFParticularInputOFthe forms.aspx.cs" Inherits="Reports_DetailedReportOFParticularInputOFthe_forms" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:TextBox ID="TxtTO" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="الي"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtFrom" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="من"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="View" runat="server" Text="مشاهدة" onclick="View_Click1" />
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="dataentry" 
                    DataTextField="name" DataValueField="id" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dataentry" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:D:\MYWORK\AZHAR.MDFConnectionString5 %>" 
                    SelectCommand="DataEntery" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
        <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
    </rsweb:ReportViewer>
</asp:Content>

