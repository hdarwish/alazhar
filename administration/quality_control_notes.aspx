<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="quality_control_notes.aspx.cs" Inherits="administration_quality_notes"
    Title="شاشة مراقب الجودة" MaintainScrollPositionOnPostback="true" EnableEventValidation="false"
    ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../user_controls/main_elements.ascx" TagName="main_elements" TagPrefix="uc2" %>
<%@ Register Src="../user_controls/support_elements.ascx" TagName="support_elements"
    TagPrefix="uc3" %>
<%@ Register Src="~/user_controls/char_moalfat.ascx" TagName="char_moalfat" TagPrefix="uc4" %>
<%@ Register Src="~/user_controls/add_reference.ascx" TagName="add_reference" TagPrefix="uc5" %>
<%@ Register Src="~/user_controls/timeline.ascx" TagName="timelineform" TagPrefix="uc6" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register Src="../user_controls/docs_authors.ascx" TagName="docs_authors" TagPrefix="uc8" %>
<%@ Register Src="../user_controls/places_translation.ascx" TagName="places_translation" TagPrefix="uc9" %>
<%@ Register Src="~/user_controls/manuscriptTab.ascx" TagName="manuscript_tab" TagPrefix="uc10"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<script language="javascript" type="text/javascript"> 
   
        function show_hide(controlID)
        {
            if(controlID=="control_div")
            {
                var param="<%=control_div.ClientID %>";
                var hiddenparam="<%=hiddinInputcontrol_div.ClientID %>";
            }
            else if(controlID=="Div1")
            {
                var param="<%=Div1.ClientID %>";
                var hiddenparam="<%=hiddinInputDiv1.ClientID %>";
            }
            else if(controlID=="Div2")
            {
                var param="<%=Div2.ClientID %>"
                var hiddenparam="<%=hiddinInputDiv2.ClientID %>";
            }
             else if(controlID=="Div3")
            {
                var param="<%=Div3.ClientID %>"
                var hiddenparam="<%=hiddinInputDiv3.ClientID %>";
            }
             else if(controlID=="Div4")
            {
                var param="<%=Div4.ClientID %>"
                var hiddenparam="<%=hiddinInputDiv4.ClientID %>";
            }
             else if(controlID=="Div5")
            {
                var param="<%=Div5.ClientID %>"
                var hiddenparam="<%=hiddinInputDiv5.ClientID %>";
            }
             else if(controlID=="Div6")
            {
                var param="<%=Div6.ClientID %>"
                var hiddenparam="<%=hiddinInputDiv6.ClientID %>";
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
    </script>--%>
    <script language="javascript" type="text/javascript">
        function Openfile(str, type) {
            var url = 'veiw_files.aspx?fname=' + str + '&type=' + type
            window.open(url);
        } 
</script> 

    <style type="text/css">
        .style2
        {
            width: 235px;
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
    <input type="hidden" id="edit_id" runat="server" />
    <asp:HiddenField ID="control_loaded" runat="server" Value="" />
    <table width="100%" dir="rtl">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="شاشة مراقب الجودة" Font-Bold="True" ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr align="right">
            <td nowrap align="right" dir="rtl" runat="server">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="نوع الاستمارة" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="object_type" runat="server" AutoPostBack="True" DataTextField="title"
                    DataValueField="id" OnSelectedIndexChanged="object_type_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td align="right" dir="rtl">
                <asp:Label ID="Label24" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" />
                &nbsp;
            </td>
        </tr>
        <%--<uc1:Smart_Search ID="Smrt_Srch_object" runat="server" />--%>
        <tr align="right" id="tr_lock" runat="server" visible="false">
            <td nowrap align="right" dir="rtl" runat="server">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="البدء في هذه الاستمارة؟" />
            </td>
            <td align="right" dir="rtl">
                <asp:Button ID="lockBtn" runat="server" OnClick="lockBtn_Click" Text="البدء" Width="39px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Style="text-align: right;
                    direction: rtl;">
                    <cc1:TabPanel ID="TabPanel1" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="تفاصيل الاستمارة" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <asp:Panel ID="control_panel" runat="server">
                            </asp:Panel>
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
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <uc6:timelineform ID="timelineform" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel4" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="المؤلفات/المؤلف عنه">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel13" runat="server">
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
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <uc5:add_reference ID="add_reference1" runat="server" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel8" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="اسم المؤلف">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                                    <uc8:docs_authors ID="docs_authors" runat="server" />
                               <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="TabPanel9" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="بيانات مكملة">
                        <ContentTemplate>
                            <%--<asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>--%>
                                    <uc9:places_translation ID="places_translation" runat="server" />
                              <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
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
                        HeaderText="ملاحظات مراقب الجودة">
                        <ContentTemplate>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                
                                 <ContentTemplate>
                                    <table id="Table1" width="100%"  runat="server" dir="<%$Resources:Master, dir%>">
                                        <tr id="Tr1" runat="server"  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                            <td id="Td1"  runat="server"  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                                <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, quality_fieldname%>"></asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:DropDownList ID="drop_fields" runat="server" >
                                                </asp:DropDownList>
                                                &nbsp;
                                                <asp:RequiredFieldValidator ID="RequiredFielddrop_fields" runat="server"  InitialValue="-- اختر نوع الحقل --"
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="drop_fields" ValidationGroup="drop"
                                     Font-Size="14px" ></asp:RequiredFieldValidator> 
                                            </td>
                                        </tr>
                                        <tr id="Tr2"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                            <td id="Td2"  valign="top"  runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, quality_errorname%>"></asp:Label>
                                                &nbsp;
                                                <asp:DropDownList ID="drop_type_wrong" runat="server" DataTextField="error_name"
                                                    DataValueField="id" OnSelectedIndexChanged="drop_type_wrong_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                 <asp:RequiredFieldValidator ID="RequiredFielddrop_type_wrong" runat="server"  InitialValue="-- اختر نوع الخطأ --"
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="drop_type_wrong" ValidationGroup="drop"
                                     Font-Size="14px" ></asp:RequiredFieldValidator> 
                                            </td>
                                        </tr>
                                        <tr id="Tr3" runat="server"  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                            <td id="Td3" valign="top" runat="server"  align="<%$Resources:Master, align%>">
                                                <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, Topics_labels_notes%>"></asp:Label>
                                                &nbsp;<asp:TextBox ID="txt_notes" runat="server" Height="45px" TextMode="MultiLine"
                                                    Width="320px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr align="center">
                                            <td align="center">
                                                <asp:Button ID="Button2" runat="server" Text="حفظ الملاحظات" OnClick="Button2_Click"
                                                    Height="28px" Width="89px"  ValidationGroup="drop"/>
                                                <asp:GridView ID="gvnotes" runat="server" AutoGenerateColumns="false" EmptyDataText=""
                                                    Width="600px" OnRowCommand="gvnotes_RowCommand" OnRowDataBound="gvnotes_RowDataBound">
                                                    <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                                    <Columns>
                                                        <asp:BoundField HeaderText=" الحقل" DataField="field_name" HeaderStyle-Width="20%"
                                                            ItemStyle-HorizontalAlign="Center" />
                                                            <asp:BoundField HeaderText=" الحقل" DataField="field_name_en" HeaderStyle-Width="20%"
                                                            ItemStyle-HorizontalAlign="Center" />
                                                            <asp:BoundField HeaderText=" الحقل" DataField="field_name_fr" HeaderStyle-Width="20%"
                                                            ItemStyle-HorizontalAlign="Center" />
                                                        <asp:BoundField HeaderText="نوع الخطأ" DataField="error_name" ItemStyle-HorizontalAlign="Center"
                                                            HeaderStyle-Width="20%" />
                                                        <asp:BoundField HeaderText="ملاحظات" DataField="observer_note" HeaderStyle-Width="40%"
                                                            ItemStyle-HorizontalAlign="Center" />
                                                        <asp:BoundField HeaderText="ملاحظات" DataField="error_status" Visible="false" />
                                                        <%-- <asp:Label ID="labid" runat="server" Visible="false" Text='<%# Eval("error_status") %>'></asp:Label>  --%>
                                                        <asp:TemplateField HeaderText="تعديل" HeaderStyle-Width="16%" ItemStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" CommandArgument='<%# Eval("id") %>'
                                                                    CommandName="EditItem" CausesValidation="false" />
                                                            </ItemTemplate>
                                                            <HeaderStyle Width="16%"></HeaderStyle>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="حذف" HeaderStyle-Width="17%">
                                                            <ItemTemplate>
                                                                <asp:ImageButton ID="ImgBtnDelete" runat="server" ImageUrl="../Images/delete.gif"
                                                                    CommandName="DeleteItem" CommandArgument='<%# Eval("id") %>' Style="height: 22px"
                                                                    OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                                                            </ItemTemplate>
                                                            <HeaderStyle Width="25px"></HeaderStyle>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </ContentTemplate>
                    </cc1:TabPanel>
                      <cc1:TabPanel ID="TabPanel11" runat="server" Font-Bold="True" ForeColor="#996633"
                        HeaderText="ملاحظة على محتوى الإستمارة" MaintainScrollPosition="true">
                        <ContentTemplate>
                            <table width="500px" align="center">
                                <tr>
                                    <td height="60px" align="center">
                                        <asp:Label ID="lbl43" runat="server" Text="ادخل ملف الاستمارة مضاف اليه التعليق على المحتوى الخطأ">
                                        </asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                   <td height="120px" align="center">
                                    <asp:FileUpload ID="fucom" runat="server" Width="100%" />
                                   </td> 
                                </tr>
		<tr>
                                    <td height="60px" align="center">
                                        تعليق :
                                        <asp:TextBox ID="txt31" runat="server" Width="100%" Height="100px" TextMode="MultiLine"></asp:TextBox> 
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Button ID="btnsavefilecomm" runat="server" onclick="btnsavefilecomm_Click" Text="إدخال"/>
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
                    
                     
                           <asp:TemplateField HeaderText="حذف" HeaderStyle-Width="25px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImgBtnDelete" runat="server" ImageUrl="../Images/delete.gif" CommandArgument='<%# Eval("id") %>' CommandName= '<%#Container.DataItemIndex+1%>'
                                        Style="height: 22px" OnClick="ImgBtnDelete_Click" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                                </ItemTemplate>

<HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>
<ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
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
        <tr dir="rtl" align="right" runat="server" id="tr_finish">
            <td align="right" colspan="1" class="style2" dir="rtl">
                <asp:CheckBox ID="chk_status" runat="server" AutoPostBack="true" />
                &nbsp;<asp:Label ID="Label5" runat="server" Text="تم الانتهاء من المراجعة"></asp:Label>
            </td>
            <td align="right" colspan="1" dir="rtl">
                <asp:Button ID="Button1" runat="server" Text="إرسال" OnClick="Button1_Click" Height="26px"
                    Width="44px" />
            </td>
        </tr>
    </table>
</asp:Content>
