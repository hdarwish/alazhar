<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="report_workLife.aspx.cs" Inherits="Reports_report" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/main_elements.ascx" TagName="main_elements" TagPrefix="uc2" %>
<%@ Register Src="../user_controls/support_elements.ascx" TagName="support_elements"
    TagPrefix="uc3" %>
<%@ Register Src="../user_controls/char_moalfat.ascx" TagName="char_moalfat" TagPrefix="uc4" %>
<%@ Register Src="../user_controls/add_reference.ascx" TagName="add_reference" TagPrefix="uc5" %>
<%@ Register Src="../user_controls/timeline.ascx" TagName="timeline" TagPrefix="uc6" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register Src="../user_controls/docs_authors.ascx" TagName="docs_authors" TagPrefix="uc8" %>
<%@ Register Src="../user_controls/places_translation.ascx" TagName="places_translation"
    TagPrefix="uc9" %>
<%@ Register Src="~/user_controls/manuscriptTab.ascx" TagName="manuscript_tab" TagPrefix="uc10" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style3
    {
        font-size: xx-large;
        height: 46px;
    }
    .style4
    {
        font-size: xx-large;
        height: 37px;
        text-align: right;
        direction: rtl;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center>
        <br />
    <asp:Label ID="Label5"  runat="server" Text="تقرير بالمناصب التى تولتها الشخصية" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center> <br />
    <table width="100%" dir="rtl" border="0">
   
    <tr>
       
        <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
              
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
    </tr>
        <tr>
            <td nowrap align="center" dir="rtl" colspan="2">
                <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" 
                    onclick="ViewReport_Click" />
            </td>
            
        </tr>
    <tr>
        <td>
            
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
                  
                </rsweb:ReportViewer>
            
            </td>
    </tr>
</table>
</asp:Content>

