<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="QualityControlDataBased.aspx.cs" Inherits="Reports_QualityControlDataBased" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style2 {
            height: 13px;
        }
    </style>
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
     <center><br />
                 <asp:Label ID="Label4"  runat="server" Text="تقرير اجمالى استمارات مراجع البيانات التى تم اعتمادها من المراجعة النهائية" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
    <table border="0" style="width:100%">
        <tr>
            <td colspan="2" align="right">
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                    AutoPostBack="True"  DataTextField="name" 
                    DataValueField="id" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">الكل</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="اسم المعتمد"></asp:Label>
            </td>
        </tr>
        <tr>
             <td colspan="2" align="right">
                <asp:TextBox ID="TextTO" runat="server" AutoPostBack="True"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="الي"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="TextFrom" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="من"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="View" runat="server" onclick="View_Click" Text="مشاهدة" />
            </td>
        </tr>
    </table>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
        
    </rsweb:ReportViewer>
</asp:content>

