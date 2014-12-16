<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="TotalFrequencyOFerrorsFiles.aspx.cs" Inherits="Reports_TotalFrequencyOFerrorsFiles" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 346px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center><br />
                 <asp:Label ID="Label5"  runat="server" Text="تقرير اجمالى مرات تكرار اخطاء مدخل الملفات " ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
    
    <table dir="rtl" width="100%">
    <tr>
       
        <td>
            <asp:Label runat="server" Text="مدخل الملفات"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
    DataTextField="name" DataValueField="id" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
</asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="من"></asp:Label>
            <asp:TextBox ID="TxtFrom" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="الي"></asp:Label>
            <asp:TextBox ID="TxtTO" runat="server"></asp:TextBox>
            
        </td>
    </tr>
        <tr>
        <td align="center">
            <asp:Button ID="View" runat="server" Text="مشاهدة" onclick="View_Click1" />
        </td>
    </tr>
         <tr>
        <td align="center">
             <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
       
    </rsweb:ReportViewer>
            </td>
    </tr>
</table>
   
</asp:Content>

