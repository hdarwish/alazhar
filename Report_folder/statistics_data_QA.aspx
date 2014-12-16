<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="statistics_data_QA.aspx.cs" Inherits="administration_entry_form" Title="شاشة إدخال الاستمارات"
    MaintainScrollPositionOnPostback="true" EnableEventValidation="false" ValidateRequest="false" %>

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
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input type="hidden" id="hiddinInputcontrol_div" runat="server" />
    <input type="hidden" id="hiddinInputDiv1" runat="server" />
    <input type="hidden" id="hiddinInputDiv2" runat="server" />
    <input type="hidden" id="hiddinInputDiv3" runat="server" />
    <input type="hidden" id="hiddinInputDiv4" runat="server" />
    <input type="hidden" id="hiddinInputDiv5" runat="server" />
    <input type="hidden" id="hiddinInputDiv6" runat="server" />
    <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>

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
                 <asp:Label ID="Label5"  runat="server" Text="تقرير احصائى لمراقب جودة البيانات " ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center> <br />
    <table width="100%" dir="rtl" border="0">
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label2" runat="server" Text="اسم مراجع البيانات    " 
                    ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                &nbsp;
                <asp:DropDownList ID="name_DropDownList" runat="server" 
                    AppendDataBoundItems="True"  DataTextField="name" 
                    DataValueField="id" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                   
                </asp:DropDownList>
               
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" ForeColor="#996633" Text="الفترة من   " 
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="Date_From" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" ForeColor="#996633" Text="   الى    " 
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="Date_To" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center">
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
        <tr align="right" dir="rtl" id="tr_finish" runat="server">
            <td colspan="2">
                </td>
        </tr>
    </table>
</asp:Content>

