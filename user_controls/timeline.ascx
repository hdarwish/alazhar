<%@ Control Language="C#" AutoEventWireup="true" CodeFile="timeline.ascx.cs" Inherits="user_controls_timeline" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<input id="timeline_id" runat="server" type="hidden" />
<input id="myRowIndex1" runat="server" type="hidden" />
<asp:HiddenField runat="server" ID="content_id" Value="" />
<asp:HiddenField runat="server" ID="content_type" Value="" />
<table style="width: 700px" border="0" cellspacing="2" runat="server" dir="<%$Resources:Master ,dir %>">
    <%--<tr>
        <td align="right" colspan="3" dir="rtl">
             <asp:Label ID="Label1" runat="server" Text=" الخط الزمني  " 
             ForeColor="Black" Font-Bold="True" Font-Size="16px"></asp:Label>
        </td>
    </tr>--%>
    <tr>
        <td colspan="3" align="center" height="40px" runat="server" dir="<%$Resources:Master ,dir %>">
            <table style="width: 100%" runat="server" id="tbl_all">
                <tr>
                    <td align="center" colspan="2">
                        <asp:Label ID="lblpage" runat="server" Text="تم الحفظ" ForeColor="red" Visible="False"
                            Font-Size="16px"></asp:Label>
                    </td>
                </tr>
                 <tr id="Tr3" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                    <td id="Td5" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>"  valign="middle">
                        <asp:Label ID="Label5" runat="server" Text="<%$Resources:Master ,timeline_hegry %>" ></asp:Label>
                    </td>
                    <td id="Td6" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" valign="top">
                        &nbsp;
                        <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master ,timeline_hegryfrom %>"  Width="25px" Height="25px"></asp:Label>
                        <asp:TextBox ID="txtHijriDatefrom" runat="server" Height="20px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label7" runat="server" Text="<%$Resources:Master ,timeline_h %>" Width="25px" Height="23px"></asp:Label>
                       
                        <br />
                        &nbsp;
                        <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master , timeline_hegryto %>" Width="25px" Height="25px"></asp:Label>
                        <asp:TextBox ID="txtHijriDateto" runat="server" Height="20px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master ,timeline_h %>" Width="25px" Height="23px"></asp:Label>
                        
                        <%-- <cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDatefrom" runat="server" FilterType="Custom"
                            TargetControlID="txtHijriDatefrom" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDateto" runat="server" FilterType="Custom"
                            TargetControlID="txtHijriDateto" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender> --%>
                    </td>
                </tr>
                <tr>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" width="100px" 
                        valign="middle">
                        <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master ,timeline_melady %>"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" valign="top">
                        &nbsp;
                        <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master ,timeline_hegryfrom %>" Width="25px" Height="25px"></asp:Label>
                        <asp:TextBox ID="txtGorgDatefrom" runat="server" Height="25px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master ,timeline_m %>" Width="25px" Height="23px"></asp:Label>
                        
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* عفوا يجب إدخال تاريخ ميلادى"
                            ControlToValidate="txtGorgDatefrom" Font-Size="12px" ValidationGroup="timeline"></asp:RequiredFieldValidator>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master ,timeline_hegryto %>" Width="25px" Height="25px"></asp:Label>
                        <asp:TextBox ID="txtGorgDateto" runat="server" Height="20px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master ,timeline_m %>" Width="25px" Height="23px"></asp:Label>
                        
                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="* عفوا يجب إدخال تاريخ ميلادى" ControlToValidate="txtGorgDateto" 
                Font-Size="14px" ValidationGroup="timeline" Height="20px" ></asp:RequiredFieldValidator> --%>
                       <%-- <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDatefrom" runat="server" FilterType="Custom"
                            TargetControlID="txtGorgDatefrom" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDateto" runat="server" FilterType="Custom"
                            TargetControlID="txtGorgDateto" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender> --%>
                    </td>
                </tr>
               
                <tr id="Tr1" runat="server" dir="<%$Resources:Master ,dir %>" 
                    align="<%$Resources:Master ,align %>" visible="False">
                    <td id="Td1" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" width="90px" valign="middle">
                        <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master ,year_timeline%>" ></asp:Label>
                    </td>
                    <td id="Td2" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" valign="top">
                        &nbsp;
                        
                        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label17" runat="server" Text="<%$Resources:Master ,timeline_m %>" Width="25px" Height="23px"></asp:Label>
                       
                        <br />
                        &nbsp;
                        
                        <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="80px" />
                        &nbsp;
                        <asp:Label ID="Label20" runat="server" Text="<%$Resources:Master ,timeline_h %>" Width="25px" Height="23px"></asp:Label>
                        
                       <%-- <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                            TargetControlID="TextBox1" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom"
                            TargetControlID="TextBox2" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender> --%>
                    </td>
                </tr>
                <tr id="Tr2" runat="server" dir="<%$Resources:Master ,dir %>" 
                    align="<%$Resources:Master ,align %>" visible="False">
                    <td id="Td3" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" width="90px" rowspan="1" valign="middle">
                        <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master ,reason_timeline %>"></asp:Label>
                    </td>
                    <td id="Td4" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                        <asp:TextBox ID="TextBox3" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" width="90px" rowspan="1" valign="middle">
                        <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master , timeline_desc %>"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                        <asp:TextBox ID="txtNotes" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* عفوا يجب إدخال وصف"
                            ControlToValidate="txtNotes" Font-Size="14px" ValidationGroup="timeline"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                    <td align="center" colspan="3" height="60px" valign="middle" runat="server" dir="<%$Resources:Master ,dir %>">
                        <asp:Button ID="btnsavetimline" runat="server" Text="إضافة" OnClick="btnsavetimline_Click"
                            ValidationGroup="timeline" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server"  dir="<%$Resources:Master ,dir %>">
        <td colspan="2" runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
            <table width="700px" id="tbl_view" runat="server">
                <tr runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
                    <td runat="server" dir="<%$Resources:Master ,dir %>">
                        <asp:GridView ID="gvMainElements" runat="server" AutoGenerateColumns="False" EmptyDataText=".. عفوا لاتوجد بيانات .."
                            BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                            <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                            <RowStyle BorderStyle="Outset" ForeColor="Black" />
                            <Columns>
                                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="3px" HeaderText="<%$Resources:Master, lbl_mosalsel%>"
                                    ItemStyle-HorizontalAlign="Center" ItemStyle-Width="3px">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex + 1%>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="<%$Resources:Master, timeline_mdatefrom%>" DataField="melady_date_from"
                                    HeaderStyle-Width="90px" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderStyle HorizontalAlign="Center" Width="90px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="<%$Resources:Master, timeline_mdateto%>" DataField="melady_date_to"
                                    HeaderStyle-Width="90px" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderStyle HorizontalAlign="Center" Width="90px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="<%$Resources:Master, timeline_hdate%>" DataField="hegry_date_from"
                                    HeaderStyle-Width="90px" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="90px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="<%$Resources:Master, timeline_hdateto%>" DataField="hegry_date_to"
                                    HeaderStyle-Width="90px" ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="90px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:BoundField>
                                <asp:BoundField HeaderText="<%$Resources:Master, timeline_desc%>" DataField="notes" HeaderStyle-Width="400px"
                                    ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="400px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="<%$Resources:Master, lbledit%>"  HeaderStyle-Width="25px">
                                    <ItemTemplate>
                                        <%-- <asp:TextBox ID="contentId2" runat="server" Visible="false" Text='<%# Eval("content_id2") %>'></asp:TextBox>
                            <asp:TextBox ID="contentType2" runat="server" Visible="false" Text='<%# Eval("content_type2") %>'></asp:TextBox>
                            <asp:TextBox ID="Relation_id" runat="server" Visible="false" Text='<%# Eval("relation_id") %>'></asp:TextBox>--%>
                                        <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" CommandArgument='<%# Eval("id") %>'
                                            CommandName='<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="<%$Resources:Master, lbldelete%>" HeaderStyle-Width="25px">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImgBtnDelete" runat="server" ImageUrl="../Images/delete.gif"
                                            CommandArgument='<%# Eval("id") %>' Style="height: 22px" OnClick="ImgBtnDelete_Click"
                                            OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </ItemStyle>
                                </asp:TemplateField>
                            </Columns>
                            <EditRowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    
   
</table>
