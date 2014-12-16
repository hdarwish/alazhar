<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Elements_moetamed.aspx.cs" Inherits="Elements_moetamed" Title="تقرير بالعناصر المعتمدة"
    MaintainScrollPositionOnPostback="true" EnableEventValidation="false" ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
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

    <table width="100%" dir="rtl">
        <tr>
            <td colspan="4">
                <asp:HiddenField ID="control_loaded" runat="server" Value="" />
                <asp:Label ID="Label1" runat="server" Text="تقرير تفصيلى بالعناصر المعتمدة في فترة زمنية معينة"
                   ForeColor="#996633" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        
        <tr><td><br /></td></tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label2" runat="server" Text="من تاريخ:" ForeColor="Black" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtDateFrom" runat="server" ValidationGroup="vg" align="right" Font-Size="13"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                    AlternateText="تقويم" Height="20px" Width="20px" />
                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDateFrom"
                    PopupButtonID="ImageButton1" Enabled="True" Format="dd/MM/yyyy">
                </cc1:CalendarExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="vg"
                    ErrorMessage="*" ControlToValidate="txtDateFrom" Display="Dynamic" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
                <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="txtDateFrom"
                    ValidChars="0987654321/\" Enabled="True" />
            </td>
            <td dir="rtl" nowrap align="right" width="9%">
                <asp:Label ID="Label4" runat="server" CssClass="Label" Text=":إلى تاريخ" Font-Bold="true"
                    Font-Size="13" />
            </td>
            <td align="right">
                <asp:TextBox ID="txtDateTo" runat="server" Font-Size="13" ValidationGroup="vg" align="right"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/Calendar_scheduleHS.png"
                    AlternateText="تقويم" Height="20px" Width="20px" />
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDateTo"
                    PopupButtonID="ImageButton2" Enabled="True" Format="dd/MM/yyyy">
                </cc1:CalendarExtender>
                <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" TargetControlID="txtDateTo"
                    ValidChars="0987654321/\" Enabled="True" />
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                &nbsp;
            </td>
            <td dir="rtl" nowrap class="style5" align="right" width="9%">
                &nbsp;
            </td>
            <td align="right" class="style5">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="Button1" runat="server" Text="Backup" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" OnClick="ViewReport_Click" />
            </td>
        </tr>
        <tr align="right" dir="rtl" id="tr1" runat="server">
            <td colspan="4" align="center">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ProcessingMode="Remote">
                    <ServerReport ReportServerUrl="http://10.60.202.103/reportserver" />
                </rsweb:ReportViewer>
            </td>
        </tr>
    </table>
</asp:Content>
