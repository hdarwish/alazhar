﻿<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="charachter_type.aspx.cs" Inherits="administration_entry_form" Title="شاشة إدخال الاستمارات"
    MaintainScrollPositionOnPostback="true" EnableEventValidation="false" ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input type="hidden" id="hiddinInputcontrol_div" runat="server" />
    <input type="hidden" id="hiddinInputDiv1" runat="server" />
    <input type="hidden" id="hiddinInputDiv2" runat="server" />
    <input type="hidden" id="hiddinInputDiv3" runat="server" />
    <input type="hidden" id="hiddinInputDiv4" runat="server" />
    <input type="hidden" id="hiddinInputDiv5" runat="server" />
    <input type="hidden" id="hiddinInputDiv6" runat="server" />
    <%--'<%=Div1.ClientID%>'--%>

    <script language="javascript" type="text/javascript">

        function show_hide(controlID) {

            var ctrID = document.getElementById(param);
            var hiddinInputCtrID = document.getElementById(hiddenparam);
            if (ctrID.style.display == 'none') {
                ctrID.style.display = 'block';
                hiddinInputCtrID.value = "1";
            }

            else {
                ctrID.style.display = 'none';
                hiddinInputCtrID.value = "0";

            }

        }  
    </script>
    <center><br />
                 <asp:Label ID="Label5"  runat="server" Text="تقرير نوع الشخصية " ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
    <table width="100%" dir="rtl">
        <tr>
            <td nowrap align="right" dir="rtl">
               
            </td>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" 
                    onclick="ViewReport_Click" />
            </td>
        </tr>
         <tr align="right" dir="rtl" id="tr1" runat="server">
            <td colspan="2" align="center">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
                    
                </rsweb:ReportViewer>
                </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr align="right" dir="rtl" id="tr_finish" runat="server">
            <td colspan="2">
                </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;
            </td>
        </tr>
    </table>
    <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
    <%--<table align="right"><tr align="right"><td>
    
    <asp:Button ID="ref_btn" runat="server" Text="حفظ المراجع" 
                        onclick="ref_btn_Click" />
    </td></tr></table>--%>
</asp:Content>
