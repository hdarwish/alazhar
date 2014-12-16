<%@ Control Language="C#" AutoEventWireup="true" CodeFile="char_moalfat.ascx.cs"
    Inherits="user_controls_char_moalfat" %>
<%@ Register Src="Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        height: 65px;
    }
    .style3
    {
        width: 100px;
    }
</style>
<%--<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>--%>
<table style="width: 700px" border="0" cellspacing="5" dir="rtl">
    <asp:HiddenField ID="content_id" runat="server" Value="" />
    <asp:HiddenField ID="content_type" runat="server" Value="" />
    <tr align="center"  width="700px">
        <td align="center">
            <table dir="rtl" cellpadding="3px" cellspacing="7px" align="right" width="700px">
                <tr id="tbl_all" runat="server">
                <td> <table >  <tr>
                    <td colspan="2" dir="rtl">
                        <asp:Label ID="Label2" runat="server" Text="الإنتاج الفكري عن الشخصية مؤلفاته/مؤلفات عنه"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td dir="rtl" >
                        <asp:Label ID="Label5" runat="server" Text="مؤلف/مؤلف عنه"></asp:Label>
                    </td>
                    <td dir="rtl">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="1">مؤلف</asp:ListItem>
                            <asp:ListItem Value="2">مؤلف عنه</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right" dir="rtl" >
                        <asp:Label ID="Label1" runat="server" Text="نوع العنصر"></asp:Label>
                    </td>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_type" runat="server" DataTextField="title" DataValueField="id"
                            Height="28px"  AutoPostBack="true" 
                            OnSelectedIndexChanged="drop_type_SelectedIndexChanged" Width="100px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" dir="rtl">
                        <asp:Label ID="Label6" runat="server" Text="بيانات بليوجرافية كاملة"></asp:Label>
                    </td>
                    <td dir="rtl" align="right" rowspan="1" valign="top" colspan="2">
                        <asp:CheckBox ID="chkcomplete" runat="server" AutoPostBack="True" OnCheckedChanged="chkcomplete_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td align="right" dir="rtl">
                        <asp:Label ID="Label7" runat="server" Text="مرشح لوضع النص الكامل على الموقع "></asp:Label>
                    </td>
                    <td dir="rtl" align="right">
                        <asp:CheckBox ID="chkcandidate" runat="server" AutoPostBack="True" OnCheckedChanged="chkcandidate_CheckedChanged" />
                    </td>
                </tr>
                <tr runat="server" id="objectname_tr">
                    <td align="right" dir="rtl" >
                        <asp:Label ID="Label4" runat="server" Text="اسم العنصر"></asp:Label>
                    </td>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="Smrt_Srch_title" runat="server" DataTextField="title" DataValueField="id"
                            Height="28px"  
                            OnSelectedIndexChanged="Smrt_Srch_title_SelectedIndexChanged" Width="200px">
                        </asp:DropDownList>
                        <%--<uc1:Smart_Search ID="Smrt_Srch_title" runat="server" />--%>
                    </td>
                </tr>
                <tr runat="server" id="newobject_tr" visible="false">
                    <td dir="rtl" align="right">
                        <asp:Label ID="Label3" runat="server" Text="اسم عنصر جديد"></asp:Label>
                    </td>
                    <td dir="rtl" align="right">
                        <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="198px"></asp:TextBox>
                    </td>
                </tr>  </table></td>
                </tr>
                
               
                
                 <tr id="tbl_translate" runat="server" align="<%$Resources:Master, align%>">
                    <td id="Td1" runat="server" align="<%$Resources:Master, align%>">
                        <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master,txt_moalf%>"></asp:Label>
                    </td>
                    <td id="Td2" runat="server" align="<%$Resources:Master, align%>">
                        <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="197px"></asp:TextBox>
                    </td>
                </tr>
                <tr align="right">
                    <td align="center" colspan="2" dir="rtl">
                        <asp:Button ID="Button1" runat="server" Text="إضافة" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <%--<tr runat="server" id="tbl_translate" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <table style="width: 700px" border="0" cellspacing="0" dir="<%$Resources:Master, dir%>" runat="server">
                <tr runat="server" align="<%$Resources:Master, align%>">
                    <td runat="server" align="<%$Resources:Master, align%>">
                        <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master,txt_moalf%>"></asp:Label>
                    </td>
                    <td runat="server" align="<%$Resources:Master, align%>">
                        <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="178px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="<%$Resources:Master, align%>"  runat="server" colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>--%>
    <tr>
        <td>
            <table dir="<%$Resources:Master, dir%>" id="tbl_view" cellspacing="7" align="<%$Resources:Master, align%>" width="600px" runat="server" >
                <tr runat="server"  align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
                    <td colspan="2" runat="server"  align="<%$Resources:Master, align%>">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="700px"
                            CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id" OnRowCommand="GridView1_RowCommand"
                            OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
                            Height="2px">
                            <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                            <Columns>
                                <asp:TemplateField HeaderText=" م">
                                    <ItemTemplate>
                                        <%# ((GridViewRow)Container).RowIndex + 1%>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="نوع العنصر" DataField="element_type" HeaderStyle-Width="120px"
                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                    ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                    HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                        Width="120px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                    </ItemStyle>
                                </asp:BoundField>
                                <%--<asp:BoundField HeaderText="الاسم" DataField="element_type_name" HeaderStyle-Width="120px"
                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                    ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                    HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />--%>
                                <asp:TemplateField HeaderText="الاسم" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="element_type_name" runat="server" Text='<%#Eval("element_type_name_ar")%>'></asp:Label>
                                        <asp:Label ID="title_ar_hidden" runat="server" Text='<%#Eval("title_ar")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Name" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="element_typeen_name" runat="server" Text=""></asp:Label>
                                        <asp:Label ID="element_type_nameen_hidden" runat="server" Text='<%#Eval("element_type_name_en")%>'
                                            Visible="false"></asp:Label>
                                        <asp:Label ID="title_en_hidden" runat="server" Text='<%#Eval("title_en")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nom" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="element_typefr_name" runat="server" Text=""></asp:Label>
                                        <asp:Label ID="element_type_namefr_hidden" runat="server" Text='<%#Eval("element_type_name_fr")%>'
                                            Visible="false"></asp:Label>
                                        <asp:Label ID="title_fr_hidden" runat="server" Text='<%#Eval("title_fr")%>' Visible="false"></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="400px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="مؤلفاته/مؤلف عنه" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="moalaf_type" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="75px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="75px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="بيانات ببليوجرافية " ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" Text="" Enabled="false" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="مرشح لوضعه" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox2" Text="" Enabled="false" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgDelete" ImageUrl="~/images/delete.gif" CommandName="DeleteItem"
                                            CausesValidation="false" CommandArgument='<%# Eval("id") %>' OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;"
                                            runat="server" OnClick="imgDelete_Click"></asp:ImageButton>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="2%">
                                    <ItemTemplate>
                                        <asp:Button ID="btn_translate" CommandArgument='<%# Eval("id") %>' CommandName="TranslateItem"
                                            runat="server" Text="ترجمة" OnClick="btn_translate_Click" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                    </HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
