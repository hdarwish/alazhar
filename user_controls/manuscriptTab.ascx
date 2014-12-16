<%@ Control Language="C#" AutoEventWireup="true" CodeFile="manuscriptTab.ascx.cs" Inherits="user_controls_manuscriptTab" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="add_reference.ascx" TagName="add_reference" TagPrefix="uc1" %>
 <asp:HiddenField ID="content_id" runat="server" />
  <input id="myRowIndex1" runat="server" type="hidden" />
   <input id="myRowIndex2" runat="server" type="hidden" />
            <asp:HiddenField ID="content_type" runat="server" />
            
<table style="width: 700px" border="0" cellspacing="5" runat="server" dir="<%$Resources:Master, dir%>" id="tblmanus">
 <tr runat="server" id="tr22" align="<%$Resources:Master, align%>">
        <td colspan="3">
            <fieldset>
                <legend>
                    <asp:Label ID="Label71" runat="server" Text="التملكات" Font-Bold="true"></asp:Label>
                </legend>
                <table id="Table1" runat="server"  align="<%$Resources:Master, align%>" >
                    <tr id="Tr1" runat="server"  align="<%$Resources:Master, align%>">
                        <td width="20px" valign="top" nowrap>
                            <asp:Label ID="Label60" runat="server" Text="التملكات"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top" colspan="2">
                            <table runat="server" style="width: 419px" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" >
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label66" runat="server" Text="<%$Resources:Master, lbl_manuscript_name %>" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;
                                    </td>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:TextBox ID="tmlkat_name" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tmlkat_name" Font-Size="14px" ValidationGroup="tamalokats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label61" runat="server" Text="تاريخ التملك" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td >
                                        <asp:TextBox ID="tmlkat_date" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButtonList ID="tmlkat_date_type" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="1">م</asp:ListItem>
                                            <asp:ListItem Value="2">هـ</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        &nbsp;
                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tmlkat_date" Font-Size="14px" ValidationGroup="tamalokats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                 <tr>
                                    <td align="right">
                                        <asp:Label ID="Label3" runat="server" Text="ملاحظات" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;
                                    </td>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:TextBox ID="txtnotes_tam" runat="server" Height="60px" 
                                            TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    </td>
                                    <td>
                                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tmlkat_name" Font-Size="14px" ValidationGroup="tamalokats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <asp:Button ID="btn_save_tamlekat" runat="server" Text="حفظ" OnClick="btn_save_tamlekat_Click"
                                            ValidationGroup="tamalokats" />
                                            <br />
                                            <asp:Button ID="btn_tamalokat_translate" runat="server" Text="ترجمه" 
                                            OnClick="btn_save_tamlekat_Click" Visible="False"
                                             />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" nowrap colspan="4">
                            <asp:GridView ID="TamalokatGridView" runat="server" AutoGenerateColumns="False" Width="716px"
                                CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="id"
                                OnRowCommand="TamalokatGridView_RowCommand">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F6F2E2" />
                                <Columns>
                                    <asp:BoundField DataField="tmlkat_name" HeaderText="الاسم" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tmlkat_name" />
                                        <asp:BoundField DataField="tmlkat_name_en" HeaderText="الاسم بالانجليزية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tmlkat_name" />
                                        <asp:BoundField DataField="tmlkat_name_fr" HeaderText="الاسم بالفرنسية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tmlkat_name" />
                                    <asp:BoundField DataField="tmlkat_date" HeaderText="تاريخ التملك" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tmlkat_date" />
                                 <asp:TemplateField HeaderStyle-HorizontalAlign="Center" >
                                        <ItemTemplate>
                                            <asp:Button ID="btn_translate" CommandArgument='<%# Eval("id") %>' 
                                                runat="server" Text="ترجمة"  OnClick="btn_Translatetmaluk" />
                                        </ItemTemplate>
                                      
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LBTDelet" CommandArgument='<%# Eval("id") %>' CommandName="RemoveItem"
                                                runat="server" ValidationGroup="tamaaalok" OnClientClick="return confirm('هل تريد الحذف؟');">حذف</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="notes" HeaderText="ملاحظات" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tmlkat_date" />
                                </Columns>
                                <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </td>
    </tr>
    <tr runat="server" id="tr23" align="<%$Resources:Master, align%>">
        <td colspan="3">
            <fieldset>
                <legend>
                    <asp:Label ID="Label72" runat="server" Text="التوقيفات" Font-Bold="true"></asp:Label>
                </legend>
                <table id="Table2"  align="<%$Resources:Master, align%>" runat="server">
                    <tr id="Tr2" align="<%$Resources:Master, align%>" runat="server">
                        <td id="Td1" width="20px" valign="top" nowrap align="<%$Resources:Master, align%>" runat="server">
                            <asp:Label ID="Label73" runat="server" Text="التوقيفات"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top">
                            <table runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label74" runat="server"  Text="<%$Resources:Master, lbl_manuscript_wa2fName %>" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;
                                    </td>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:TextBox ID="tawkifat_name" runat="server" ValidationGroup="tawkifats"></asp:TextBox>
                                    </td>
                                    <td>
                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tawkifat_name" Font-Size="14px" ValidationGroup="tawkifats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server"  Text="<%$Resources:Master, lbl_manuscript_wa2f_on_Name %>" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;
                                    </td>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:TextBox ID="tawkifat_on_name" runat="server" ValidationGroup="tawkifats"></asp:TextBox>
                                    </td>
                                    <td>
                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tawkifat_name" Font-Size="14px" ValidationGroup="tawkifats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label75" runat="server" Text="تاريخ الوقف" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <asp:TextBox ID="tawkifat_date" runat="server" ValidationGroup="tawkifats"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButtonList ID="tawkifat_date_type" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="1">م</asp:ListItem>
                                            <asp:ListItem Value="2">هـ</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tawkifat_date" Font-Size="14px" ValidationGroup="tawkifats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                 <tr>
                                    <td align="right">
                                        <asp:Label ID="Label2" runat="server"  Text="ملاحظات" ForeColor="#996633"></asp:Label>&nbsp;&nbsp;
                                    </td>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                                        <asp:TextBox ID="txtnotes" runat="server"  Height="60px" 
                                            TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                                            ControlToValidate="tawkifat_name" Font-Size="14px" ValidationGroup="tawkifats"></asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <asp:Button ID="btn_save_tawkifat" runat="server" Text="حفظ" OnClick="btn_save_tawkifat_Click"
                                            ValidationGroup="tawkifats" />
                                            <br />
                                            <asp:Button ID="btn_translate_tawkifat" runat="server" Text="ترجمة" 
                                            OnClick="btn_save_tawkifat_Click" Visible="False"
                                            />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td width="150px" align="right" valign="top" nowrap>
                            &nbsp;
                        </td>
                    </tr>
                    <tr runat="server" id="tr_grid_tawfikat">
                        <td valign="top" nowrap colspan="4">
                            <asp:GridView ID="TawfikatGridView" runat="server" AutoGenerateColumns="False" Width="716px"
                                CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="id"
                                OnRowCommand="TawfikatGridView_RowCommand">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F6F2E2" />
                                <Columns>
                                    <asp:BoundField DataField="tawkifat_name" HeaderText="اسم الواقف" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_name_en" HeaderText="اسم الواقف بالانجليزية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_name_fr" HeaderText="اسم الواقف بالفرنسية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                      <asp:BoundField DataField="tawkifat_on_name" HeaderText=" الموقوف عليه" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_on_name_en" HeaderText=" الموقوف عليه بالانجليزية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_on_name_fr" HeaderText=" الموقوف عليه بالفرنسية" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="tawkifat_date" HeaderText="تاريخ الوقف" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_date">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderStyle-HorizontalAlign="Center" >
                                        <ItemTemplate>
                                            <asp:Button ID="btn_translate_edit" CommandArgument='<%# Eval("id") %>'
                                                runat="server" Text="ترجمة"   OnClick="btn_Translatetawkif" />
                                        </ItemTemplate>
                                      
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LBTDelet" CommandArgument='<%# Eval("id") %>' CommandName="RemoveItem"
                                                runat="server" ValidationGroup="tawkeefat" OnClientClick="return confirm('هل تريد الحذف؟');">حذف</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                      <asp:BoundField DataField="notes" HeaderText=" ملاحظات" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        SortExpression="tawkifat_name">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                </Columns>
                                <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </td>
    </tr>
    </table>
