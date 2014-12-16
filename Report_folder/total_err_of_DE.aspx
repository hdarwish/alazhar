<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="total_err_of_DE.aspx.cs" Inherits="administration_entry_form" Title="شاشة إدخال الاستمارات"
    MaintainScrollPositionOnPostback="true" EnableEventValidation="false" ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        h3
        {
        }
        .style1
        {
            height: 167px;
            text-align: center;
        }
    </style>
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
    <asp:UpdatePanel ID="up1" runat="server" >
    <ContentTemplate>

        
         <center><br />
                 <asp:Label ID="Label5"  runat="server" Text="تقرير اجمالى اخطاء مدخل البيانات  " ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center> <br />
    <table width="100%" dir="rtl" border="0">
       
        <tr>
            <td colspan="2" >
               <asp:Label ID="Label24" runat="server" Text="Label">مدخل البيانات</asp:Label>
                <asp:DropDownList 
                    ID="DropDownList1" runat="server" 
                    DataTextField="name" 
                    DataValueField="id" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
                </asp:DropDownList>
             
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label25" runat="server" Text="Label">فترة من</asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="128px"></asp:TextBox>

                 &nbsp;&nbsp;&nbsp;<asp:Label ID="Label26" runat="server" Text="Label">الى</asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
           
        </tr>
       
        <tr>
            <td align="center">
                <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" 
                    onclick="ViewReport_Click" />
            </td>
        </tr>
         <tr align="right" dir="rtl" id="tr1" runat="server" valign="top">
            <td align="right" dir="rtl" valign="top">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote" ShowParameterPrompts="False">
                   
                </rsweb:ReportViewer>
                </td>
        </tr>
       
    </table>
    </ContentTemplate>
    <Triggers>
    <asp:PostBackTrigger ControlID="ViewReport" />
    </Triggers>
    </asp:UpdatePanel>
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
