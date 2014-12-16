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
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
            width: 573px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style1">
        <tr>
            <td  colspan="2">
              
                 <center><br />
                 <asp:Label ID="Label1"  runat="server" Text="تقرير المراجع التى تم ادخالها" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               <br /><br />
                 </center>
            </td>
        </tr>
        <tr>
            <td style="text-align: right" align="right" class="auto-style2">
                <asp:DropDownList ID="object_type" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                </asp:DropDownList>
              
            </td>
            <td align="right" class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="نوع الاستمارة" ForeColor="#996633" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: right">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ProcessingMode="Remote">
                   
                </rsweb:ReportViewer>
            </td>
        </tr>
    </table>
</asp:Content>
