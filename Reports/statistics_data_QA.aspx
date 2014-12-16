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

    <table width="100%" dir="rtl">
        <tr>
            <td colspan="2">
                <asp:HiddenField ID="control_loaded" runat="server" Value="" />
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label2" runat="server" Text="اسم مراجع البيانات    " 
                    ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                &nbsp;
                <asp:DropDownList ID="name_DropDownList" runat="server" 
                    AppendDataBoundItems="True" DataSourceID="SqlDataSource1" DataTextField="name" 
                    DataValueField="id" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">none</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="Data Source=m303-hafs;Initial Catalog=azhar_live;Persist Security Info=True;User ID=sa;Password=sa" 
                    ProviderName="System.Data.SqlClient" 
                    SelectCommand="SELECT [id], [name] FROM [users] WHERE ([user_type] = @user_type)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="5" Name="user_type" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td nowrap align="right" dir="rtl">
                &nbsp;</td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" ForeColor="#996633" Text="الفترة من   " 
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="Date_From" runat="server"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" ForeColor="#996633" Text="   الى    " 
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="Date_To" runat="server"></asp:TextBox>
            </td>
            <td nowrap align="right" dir="rtl">
                &nbsp;</td>
        </tr>
        <tr>
            <%--<table align="right"><tr align="right"><td>
    
    <asp:Button ID="ref_btn" runat="server" Text="حفظ المراجع" 
                        onclick="ref_btn_Click" />
    </td></tr></table>--%>
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
                    <ServerReport ReportServerUrl="http://10.60.202.37/reportserver" />
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

