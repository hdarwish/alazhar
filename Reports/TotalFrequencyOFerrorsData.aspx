<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="TotalFrequencyOFerrorsData.aspx.cs" Inherits="Reports_TotalFrequencyOFerrors" %><%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
            height: 89px;
        }
        .style2
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td>
<asp:SqlDataSource ID="SqlDataSourceDataIn" runat="server" 
    ConnectionString="<%$ ConnectionStrings:D:\MYWORK\AZHAR.MDFConnectionString3 %>" 
    SelectCommand="DataEntery" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
    DataSourceID="SqlDataSourceDataIn" DataTextField="name" DataValueField="id" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TxtTO" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="الي"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtFrom" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="من"></asp:Label>
        </td>
    </tr>
</table>
<br />
    <table class="style2">
        <tr>
            <td>
                <asp:Button ID="View" runat="server" onclick="View_Click" Text="مشاهدة" />
            </td>
        </tr>
    </table>
<br />
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="79%" 
                    ProcessingMode="Remote">
        <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
    </rsweb:ReportViewer>
</asp:Content>

