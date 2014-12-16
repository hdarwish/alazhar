<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="QualityControlDataBased.aspx.cs" Inherits="Reports_QualityControlDataBased" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 13px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                    AutoPostBack="True" DataSourceID="SqlDataSourceMo3tamed" DataTextField="name" 
                    DataValueField="id" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">الكل</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceMo3tamed" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:D:\MYWORK\AZHAR.MDFConnectionString6 %>" 
                    SelectCommand="FinalRevisioner" SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="اسم المعتمد"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:TextBox ID="TextTO" runat="server" AutoPostBack="True"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="الي"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextFrom" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="من"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="View" runat="server" onclick="View_Click" Text="مشاهدة" />
            </td>
        </tr>
    </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
        <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
    </rsweb:ReportViewer>
</asp:Content>

