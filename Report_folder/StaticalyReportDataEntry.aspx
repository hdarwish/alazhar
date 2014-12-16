<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="StaticalyReportDataEntry.aspx.cs" Inherits="Reports_StaticalyReportDataEntry" %>

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
     <center><br />
                 <asp:Label ID="Label4"  runat="server" Text="تقرير اجمالى استمارات مدخل البيانات" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               <br /><br />
                 </center>
    <table border="0" width="100%">
        <tr align="right">
            <td align="right">
                
               
            </td>
            <td align="right">
                
                
                <asp:DropDownList ID="DropDownList1" runat="server" 
                     DataTextField="name" 
                    DataValueField="id" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="اسم مدخل البيانات"></asp:Label>
            </td>
        </tr>
        <tr >
            <td align="right" colspan="2">
                <asp:TextBox ID="TxtTO" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="الي"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TxtFrom" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="من"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="View" runat="server" Text="مشاهدة" onclick="View_Click" />
            </td>
        </tr>
    </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
        
    </rsweb:ReportViewer>
</asp:Content>

