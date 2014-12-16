<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="final_revision_home.aspx.cs" Inherits="administration_final_revision_home"
    EnableEventValidation="false" ValidateRequest="false" Title="" MaintainScrollPositionOnPostback="true"  %>

<%@ Register Src="../user_controls/char_moalfat.ascx" TagName="char_moalfat" TagPrefix="uc4" %>
<%@ Register Src="../user_controls/add_reference.ascx" TagName="add_reference" TagPrefix="uc5" %>
<%@ Register Src="../user_controls/timeline.ascx" TagName="timeline" TagPrefix="uc6" %>
<%@ Register Src="~/user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/main_elements.ascx" TagName="main_elements" TagPrefix="uc2" %>
<%@ Register Src="../user_controls/support_elements.ascx" TagName="support_elements"
    TagPrefix="uc3" %>
<%@ Register Src="../user_controls/docs_authors.ascx" TagName="docs_authors" TagPrefix="uc8" %>
<%@ Register Src="../user_controls/places_translation.ascx" TagName="places_translation"
    TagPrefix="uc9" %>
<%@ Register Src="~/user_controls/manuscriptTab.ascx" TagName="manuscript_tab" TagPrefix="uc10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script language="javascript">
    function show_hide(controlID)
    {
        var ctrID = document.getElementById(controlID);
        if(ctrID.style.display == 'none')
            ctrID.style.display = 'block';
        else
            ctrID.style.display = 'none';
    }
     function Openfile(str,type) 
       { 
        var url = 'veiw_files.aspx?fname='+str+'&type='+type
         window.open(url); 
       } 
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" dir="rtl" cellpadding="5" cellspacing="5" border="0">
        <tr>
            <td colspan="2">
                <asp:HiddenField ID="control_loaded" runat="server" Value="" />
                <asp:Label ID="Label1" runat="server" Text="المراجعة النهائية - الإعتماد" Font-Bold="True"
                    ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td nowrap>
                <asp:Label ID="Label2" runat="server" Text="نوع الاستمارة"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="object_type" runat="server" DataTextField="title" DataValueField="id"
                    AutoPostBack="True" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td nowrap>
                <asp:Label ID="Label3" runat="server" Text="الإســـــم"></asp:Label>
                &nbsp;&nbsp;
                <uc1:Smart_Search ID="Smrt_Srch_object" runat="server" />
            </td>
        </tr>
        <tr id="lockTr" runat="server" visible="false">
            <td align="right" colspan="2">
                <asp:CheckBox ID="lockChckBox" Text="البدء في عمل هذه الاستمارة؟" runat="server" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="lockBtn" runat="server" Text="البدء" ValidationGroup="vgrup" OnClick="lockBtn_Click" />
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
                    <cc1:TabPanel ID="TabPanel1" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="تفاصيل الاستمارة">
                        <ContentTemplate>
                            <asp:Panel ID="control_panel" runat="server">
                            </asp:Panel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel2" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="العناصر الأساسية المرتبطة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <uc2:main_elements ID="main_elements1" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                       <cc1:TabPanel ID="TabPanel8" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="الخط الزمنى">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>
                                    <uc6:timeline ID="timeline" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                      <cc1:TabPanel ID="TabPanel6" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="المؤلفات/المؤلف عنه">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <uc4:char_moalfat ID="char_moalfat" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel3" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="العناصر الداعمة المرتبطة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <uc3:support_elements ID="support_elements2" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                 
                   
                    <cc1:TabPanel ID="TabPanel7" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="المراجـع">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>
                                    <uc5:add_reference ID="add_reference1" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel4" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="الملفات المرفقة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="124px"
                                        Width="716px" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True"
                                        DataKeyNames="id" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <RowStyle BackColor="#F6F2E2" />
                                        <Columns>
                                            <%-- <asp:BoundField DataField="field_name" HeaderText="اسم الملف" ItemStyle-HorizontalAlign="Center"
                                                SortExpression="username" />--%>
                                            <asp:TemplateField HeaderText="اسم الملف" ItemStyle-HorizontalAlign="Center" ItemStyle-CssClass="linkdir" ControlStyle-CssClass="linkdir">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="title" runat="server" Text='<%# Eval("title") %>' CommandName='<%#Container.DataItemIndex %>'
                                                        CausesValidation="false">
                                                    </asp:LinkButton>
                                                    <%-- <a href="#" runat="server" onclick="title_Click" target="_blank" ><%# Eval("title") %></a>--%>
                                                    <%-- <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" 
                                CommandArgument='<%# Eval("id") %>'
                                    CommandName= '<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />--%>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                                </HeaderStyle>
                                                <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                                </ItemStyle>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="usage" HeaderText="استخدام الملف" HeaderStyle-Width="100px"
                                                ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                                HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" SortExpression="title" />
                                            <%-- <asp:TemplateField HeaderText="عرض" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("valid_extension") %>'>عرض</asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>--%>
                                        </Columns>
                                        <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel5" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="أخطاء الملفات">
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Label ID="Label12" runat="server" Text="استخدام الملف : " Font-Bold="True"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="usage_id" runat="server" DataTextField="usage" DataValueField="id"
                                            ValidationGroup="errors_elements">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Label ID="Label5" runat="server" Text="نوع الخطأ : " Font-Bold="True"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="error_type" runat="server" DataTextField="error_name" DataValueField="id"
                                            ValidationGroup="errors_elements">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Label ID="Label6" runat="server" Text="مكان الخطأ :" Font-Bold="True"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                                            <asp:Label ID="Label7" runat="server" Text="ثانية :"></asp:Label>&nbsp;&nbsp;
                                            <asp:TextBox ID="second" runat="server" Width="40px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label8" runat="server" Text="دقيقة :"></asp:Label>&nbsp;&nbsp;
                                            <asp:TextBox ID="minute" runat="server" Width="40px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label9" runat="server" Text="ساعة :"></asp:Label>&nbsp;&nbsp;
                                            <asp:TextBox ID="hours" runat="server" Width="40px"></asp:TextBox>
                                        </asp:Panel>
                                        <asp:Panel ID="Panel2" runat="server" Visible="false">
                                            <asp:Label ID="Label10" runat="server" Text="رقم الصفحة :"></asp:Label>&nbsp;&nbsp;
                                            <asp:TextBox ID="page_no" runat="server" Width="40px"></asp:TextBox>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Label ID="Label11" runat="server" Text="ملاحظات : " Font-Bold="True"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="notes" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Button ID="btn_save_errors" runat="server" Text="حفـــظ" OnClick="btn_save_errors_Click"
                                            ValidationGroup="errors_elements" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Height="124px"
                                Width="716px" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True"
                                DataKeyNames="id" OnRowCommand="GridView2_RowCommand" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F6F2E2" />
                                <Columns>
                                    <asp:BoundField DataField="revision_note_date" HeaderText="تاريخ الخطأ" ItemStyle-HorizontalAlign="Center"
                                        SortExpression="username" />
                                    <asp:BoundField DataField="usage" HeaderText="استخدام الملف" ItemStyle-HorizontalAlign="Center"
                                        SortExpression="title" />
                                    <asp:BoundField DataField="error_name" HeaderText="نوع الخطأ" ItemStyle-HorizontalAlign="Center"
                                        SortExpression="username" />
                                    <asp:BoundField DataField="error_place" HeaderText="مكان الخطأ" ItemStyle-HorizontalAlign="Center"
                                        SortExpression="title" />
                                    <asp:BoundField DataField="revision_note" HeaderText="ملاحظات" ItemStyle-HorizontalAlign="Center"
                                        SortExpression="E_mail" />
                                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LBTDelet" CommandArgument='<%# Eval("ID") %>' CommandName="RemoveItem"
                                                runat="server" OnClientClick="return confirm('هل تريد حذف  بيانات هذا الخطأ ؟');">
                             حذف</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%--
                                            <asp:HyperLinkField DataNavigateUrlFields="id" ItemStyle-HorizontalAlign="Center"
                                                DataNavigateUrlFormatString="Add_new_researsher.aspx?id={0}" HeaderText="تعديل"
                                                NavigateUrl="Add_new_researsher.aspx" Text="تعديل" />--%>
                                </Columns>
                                <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                            </asp:GridView>
                        </ContentTemplate>
                    </cc1:TabPanel>
                   
                    <cc1:TabPanel ID="TabPanel9" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="اسم المؤلف">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                            <uc8:docs_authors ID="docs_authors" runat="server" />
                            <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel10" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="بيانات مكملة">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                            <uc9:places_translation ID="places_translation" runat="server" />
                            <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel11" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="بيانات مكملة">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                            <uc10:manuscript_tab ID="manuscript_tab1" runat="server" />
                            <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    
                    
                    <cc1:TabPanel ID="TabPanel12" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="ملاحظة على محتوى الإستمارة" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <table width="500px" align="center">
                                <tr>
                                    <td height="60px" align="center">
                                        تعليق :
                                        <asp:TextBox ID="txt31" runat="server" Width="100%" TextMode="MultiLine" ReadOnly="True"></asp:TextBox> 
                                    </td>
                                </tr>
                                
                               
                                <tr>
        <td >
            <asp:GridView ID="gvContentFiles" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد بيانات .." Width="100%"  BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px"  OnRowDataBound="gvContentFiles_RowDataBound" Visible="true" >
             <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                <Columns>
                   
                    
                     <%--<asp:BoundField HeaderText="اسم الملف" DataField="title" ItemStyle-HorizontalAlign="Center" />--%>
                     <asp:TemplateField HeaderText="اسم الملف"  ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                              <asp:linkbutton id="title" runat="server" Text='<%# Eval("file_name") %>' 
                            
                                 
                                    CommandName= '<%#Container.DataItemIndex %>'  CausesValidation="false">
                                    </asp:linkbutton>
                                  <%-- <a href="#" runat="server" onclick="title_Click" target="_blank" ><%# Eval("title") %></a>--%>
                               <%-- <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" 
                                CommandArgument='<%# Eval("id") %>'
                                    CommandName= '<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />--%>
                              </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>

                        </asp:TemplateField>
                    
                     
                          
                          
                </Columns>
             </asp:GridView>
        </td>
    </tr>
                            </table>
                        </ContentTemplate>
                    </cc1:TabPanel>

                </cc1:TabContainer>
            </td>
        </tr>
        <%--  <tr id="tr_e3tmad0" runat="server">
            <td align="right" colspan="2">
                <asp:RadioButtonList ID="status" runat="server">
                    <asp:ListItem Text="الملف غير مطابق للاستمارة" Value="0"></asp:ListItem>
                    <asp:ListItem Text="تم الانتهاء من الاعتماد" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>--%>
        <tr id="tr_file" runat="server" align="right" colspan="2">
            <td>
                <asp:RadioButtonList ID="radlist" runat="server">
                    <asp:ListItem Text="الملف غير مطابق للاستمارة" Value="0"></asp:ListItem>
                    <asp:ListItem Text="تم الانتهاء من الاعتماد" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <%--<asp:RadioButton ID="chk_file" runat="server" Text="الملف غير مطابق للاستمارة"/>
                
            
            </td>
        </tr>
        <tr id="tr_e3tmad" runat="server" align="right" colspan="2">
            <td>
           
                <asp:RadioButton ID="chk_finished" runat="server" Text="تم الانتهاء من الاعتماد"/>
            </td>
        </tr>--%>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btn_save_all" runat="server" Text="حفظ بيانات الاستمارة" OnClick="btn_save_all_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
