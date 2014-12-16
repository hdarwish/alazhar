<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="ReportViewer.aspx.cs" Inherits="administration_entry_form" Title="شاشة إدخال الاستمارات"
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
   
        function show_hide(controlID)
        {
            
            var ctrID =  document.getElementById(param);
            var hiddinInputCtrID = document.getElementById(hiddenparam);
            if(ctrID.style.display == 'none')
               {
                ctrID.style.display = 'block';
                hiddinInputCtrID.value="1";
               } 
                
            else
            {
                ctrID.style.display = 'none';
                hiddinInputCtrID.value="0";
               
             }
        
          }  
    </script>

    <table width="100%" dir="rtl">
        <tr>
            <td colspan="2">
                <asp:HiddenField ID="control_loaded" runat="server" Value="" />
                <asp:Label ID="Label1" runat="server" Text="شاشة إدخال الاستمارات" Font-Bold="True"
                    ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label2" runat="server" Text="نوع الاستمارة" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="object_type" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                </asp:DropDownList>
                 <asp:DropDownList ID="object_type1" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type1_SelectedIndexChanged" Visible="false">
                </asp:DropDownList>
            </td>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                    <asp:Label ID="lblfrom" runat="server" Text="من"></asp:Label>
                    <asp:TextBox ID="txtfrom" runat="server" Width="132px"></asp:TextBox>
                    <asp:Label ID="lblto" runat="server" Text="إلى"></asp:Label>
                    <asp:TextBox ID="txtto" runat="server" Width="138px"></asp:TextBox>
                    <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
        </tr>
        <tr id="tr_lock" runat="server" visible="false">
            <td nowrap align="right" dir="rtl">
                &nbsp;</td>
            <td nowrap align="right" dir="rtl">
                &nbsp;</td>
        </tr>
        <tr>
           
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" 
                    onclick="ViewReport_Click" />
            </td>
        </tr>
         <tr align="right" dir="rtl" id="tr1" runat="server">
            <td colspan="2" align="center">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote">
                    <ServerReport ReportServerUrl="http://10.60.202.103/reportserver" />
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
