<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master"
    AutoEventWireup="true" CodeFile="ReportRelation_Elements.aspx.cs" Inherits="Reports_ReportRelation_Elements" %>

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
            <td colspan="2">
                <asp:HiddenField ID="control_loaded" runat="server" Value="" />
                <asp:Label ID="Label1" runat="server" Text="شاشة إدخال الاستمارات" Font-Bold="True"
                    ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label2" runat="server" Text="نوع العنصر الأساسي" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="object_type" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                     <asp:ListItem Text="اختر نوع العنصر" Value="0"></asp:ListItem>
                    <asp:ListItem Text="الشخصيات" Value="1"></asp:ListItem>
                      <asp:ListItem Text="الأحداث" Value="2"></asp:ListItem>
                      <asp:ListItem Text="الموضوعات" Value="3"></asp:ListItem>
                       <asp:ListItem Text="الأماكن" Value="4"></asp:ListItem>
                </asp:DropDownList></td>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>                <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
        </tr>
        <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
        <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
        <tr nowrap align="right" dir="rtl">
            <td colspan="4">
                <asp:Label ID="Label4" runat="server" Text=" نوع العنصر المرتبط" ForeColor="#996633"
                    Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="object_type2" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                </asp:DropDownList>
                <tr id="tr_lock" runat="server" visible="false">
                    <td nowrap align="right" dir="rtl">
                        &nbsp;
                    </td>
                    <td nowrap align="right" dir="rtl">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <%--<table align="right"><tr align="right"><td>
    
    <asp:Button ID="ref_btn" runat="server" Text="حفظ المراجع" 
                        onclick="ref_btn_Click" />
    </td></tr></table>--%>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="ViewReport" runat="server" Text="مشاهدة" OnClick="ViewReport_Click" />
                    </td>
                </tr>
                <tr align="right" dir="rtl" id="tr1" runat="server">
                    <td colspan="2" align="center">
                        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ProcessingMode="Remote">
                            <ServerReport ReportServerUrl="http://10.60.201.56/reportserver" />
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
