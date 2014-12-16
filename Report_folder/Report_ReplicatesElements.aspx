<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Report_ReplicatesElements.aspx.cs" Inherits="Reports_Report_ReplicatesElements" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <table class="style1" border="0">
    <tr>
        <td colspan="2">
            <center><br />
                 <asp:Label ID="Label4"  runat="server" Text="تقرير مكررات العناصر" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
            </td>
    </tr>
    <tr>
        <td style="text-align: right" colspan="2">
            <asp:DropDownList ID="object_type" runat="server" 
                DataTextField="title" DataValueField="id" 
                onselectedindexchanged="object_type_SelectedIndexChanged" 
                AutoPostBack="True">
            </asp:DropDownList>
           &nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" Text="نوع العنصر"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%">
            </rsweb:ReportViewer>
        </td>
    </tr>
</table>
</asp:content>

