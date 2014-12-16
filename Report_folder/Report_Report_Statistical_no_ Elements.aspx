<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Report_Report_Statistical_no_ Elements.aspx.cs" Inherits="Reports_Report_Report_Statistical_no__Elements" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><br />
        <asp:Label ID="Label2"  runat="server" Text="تقرير احصائى بعدد العناصر وحالتها" ForeColor="#996633" Font-Bold="True"></asp:Label>
        <br />
    </center>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%">
    </rsweb:ReportViewer>
</asp:Content>

