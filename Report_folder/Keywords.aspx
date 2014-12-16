<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Keywords.aspx.cs" Inherits="Reports_Keywords" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center><br />
                 <asp:Label ID="Label5"  runat="server" Text="تقرير الكلمات الدالة " ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
    
    <table dir="rtl" width="100%">
           <tr>
            <td  colspan="2">
                <asp:Label runat="server" Text="نوع الاستمارة"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
    DataTextField="title" DataValueField="id" 
        AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
                </td>
               </tr>
        <tr>
            <td  colspan="2">
       
<rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote" style="margin-top: 82px">
  
</rsweb:ReportViewer>
                </td>
             </tr>
        </table>  
</asp:Content>

