<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="entry_form.aspx.cs" Inherits="administration_entry_form" Title="شاشة إدخال الاستمارات"
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
<%@ Register assembly="System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="System.Web.UI" tagprefix="cc2" %>
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
    <%--<td align="right" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="تفاصيل الاستمارة" Font-Bold="True" ForeColor="#996633"></asp:Label>
            </td>--%>

    <script language="javascript" type="text/javascript"> 
   
        function show_hide(controlID)
        {
            if(controlID=="TabPanel2")
            {
                var param="<%=TabPanel2.ClientID %>";
                var hiddenparam="<%=hiddinInputDiv2.ClientID %>";
            }
            else if(controlID=="TabPanel5")
            {
                var param="<%=TabPanel5.ClientID %>";
                var hiddenparam="<%=hiddinInputDiv5.ClientID %>";
            }
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
            </td>
            <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                <%-- <asp:DropDownList ID="Smrt_Srch_object" Width="400px" runat="server" DataTextField="newcode"
                    DataValueField="id" AutoPostBack="True" OnSelectedIndexChanged="Smrt_Srch_object_SelectedIndexChanged">
                    <asp:ListItem Text=" -- اختر العنصر -- " Value="0"></asp:ListItem>
                </asp:DropDownList>--%>
                <%--'<%=Div1.ClientID%>'--%>
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
        </tr>
        <tr id="tr_lock" runat="server" visible="false">
            <td nowrap align="right" dir="rtl">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="البدء في عمل هذه الاستمارة؟" />
            </td>
            <td nowrap align="right" dir="rtl">
                <asp:Button ID="lockBtn" runat="server" OnClick="lockBtn_Click" Text="البدء" />
            </td>
        </tr>
        <tr>
            <%--</ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
        </tr>
        <tr>
            <td colspan="2">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Style="text-align: right;
                    direction: rtl;">
                    <cc1:TabPanel ID="TabPanel1" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="تفاصيل الاستمارة" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel5" runat="server" ChildrenAsTriggers="true">
                                <ContentTemplate>--%>
                            <asp:Panel ID="control_panel" runat="server" MaintainScrollPosition="true">
                            </asp:Panel>
                            <%--</ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel2" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="العناصر الأساسية المرتبطة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <uc2:main_elements ID="main_elements" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                     <cc1:TabPanel ID="TabPanel6" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="الخط الزمنى">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <uc6:timeline ID="timeline" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel4" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="المؤلفات/المؤلف عنه">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <uc4:char_moalfat ID="char_moalfat" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel3" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="العناصر الداعمة المرتبطة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <uc3:support_elements ID="support_elements" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    
                      <cc1:TabPanel ID="TabPanel5" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="المراجـع">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <uc5:add_reference ID="add_reference1" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel8" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="اسم المؤلف">
                        <ContentTemplate>
                            <%-- <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                            <uc8:docs_authors ID="docs_authors" runat="server" />
                            <%--</ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel9" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="بيانات مكملة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>
                                    <uc9:places_translation ID="places_translation" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel10" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="بيانات مكملة">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                            <uc10:manuscript_tab ID="manuscript_tab1" runat="server" />
                            <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                  
                   
                    <cc1:TabPanel ID="TabPanel7" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="ملاحظات مراقب الجودة" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="gvnotes" BorderWidth="0" runat="server" AutoGenerateColumns="false"
                                        EmptyDataText="" Width="100%">
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <RowStyle BackColor="#F6F2E2" />
                                        <Columns>
                                            <asp:BoundField HeaderText=" الحقل" DataField="field_name" HeaderStyle-Width="50px"
                                                ItemStyle-HorizontalAlign="Center" />
                                            <asp:BoundField HeaderText=" الحقل" DataField="field_name_en" HeaderStyle-Width="50px"
                                                ItemStyle-HorizontalAlign="Center" />
                                            <asp:BoundField HeaderText=" الحقل" DataField="field_name_fr" HeaderStyle-Width="50px"
                                                ItemStyle-HorizontalAlign="Center" />
                                            <asp:BoundField HeaderText="نوع الخطأ" DataField="error_name" ItemStyle-HorizontalAlign="Center"
                                                HeaderStyle-Width="50px" />
                                            <asp:BoundField HeaderText="ملاحظات مراقب الجودة" DataField="observer_note" HeaderStyle-Width="150px"
                                                ItemStyle-HorizontalAlign="Center" />
                                            <asp:BoundField HeaderText="تاريخ الملاحظة" DataField="observer_note_date" HeaderStyle-Width="100px"
                                                ItemStyle-HorizontalAlign="Center" Visible="true" />
                                        </Columns>
                                        <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" BorderWidth="0" />
                                        <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                </cc1:TabContainer>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr align="right" dir="rtl" id="tr_finish" runat="server">
            <td colspan="2">
                <asp:CheckBox ID="chk_status" runat="server" AutoPostBack="True" />
                <asp:Label ID="Label5" runat="server" Text="تم الانتهاء من الإدخال"></asp:Label>
                &nbsp;<asp:Button ID="Save" runat="server" Font-Bold="True" 
                    OnClick="Save_Click" Text="إرسال"
                    Width="59px" />
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
