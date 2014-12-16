<%@ Control Language="C#" AutoEventWireup="true" CodeFile="docs_authors.ascx.cs" Inherits="user_controls_docs_authors" %>

<style type="text/css">
    .style1
    {
        height: 26px;
    }
</style>

<table>
<asp:HiddenField ID="content_type" runat="server" />
            <asp:HiddenField ID="content_id" runat="server" />
             <input id="myRowIndex1" runat="server" type="hidden" />
<tr id="tr_1" runat="server" align="<%$Resources:Master, align%>">
        <td id="Td1"  align="<%$Resources:Master, align%>" runat="server">
            <asp:UpdatePanel ID="Panel1" runat="server">
              
              <ContentTemplate>
                <table>
                    <tr  id="trmoalf" runat="server" align="<%$Resources:Master, align%>">
                        <td>
                            <table width="700px" >
                                <tr align="right">
                                    <td rowspan="3" align="right" dir="rtl" valign="top">
                                        <asp:Label ID="Label20" runat="server" Text="<%$Resources:Master, Lbl_book_Author %>"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        من الشخصيات
                                    </td>
                                    <td dir="rtl">
                                        اسم مؤلف جديد
                                    </td>
                                </tr>
                                <tr width="700px">
                                    <td>
                                        <asp:DropDownList ID="drop_char" runat="server" DataTextField="name" DataValueField="id"
                                            AutoPostBack="True" Width="250" OnSelectedIndexChanged="drop_char_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right" dir="rtl" valign="top">
                                        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                                    </td>
                                
                                </tr>
                                 <tr runat="server" id="tr_author_type">
                                    <td class="style1">
                                        <asp:Label ID="Label22" runat="server" Text=" نوع المؤلف:"></asp:Label>
                                    </td>
                                    <td colspan="2" align="right" dir="rtl" class="style1">
                                        <asp:DropDownList ID="drop_author_type" runat="server" DataTextField="author_type"
                                            DataValueField="id" Width="179px" >
                                        </asp:DropDownList>

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label23" runat="server" Text=" دور المؤلف:"></asp:Label>
                                    </td>
                                    <td colspan="2" align="right" dir="rtl">
                                        <asp:DropDownList ID="drop_role" runat="server" DataTextField="author_role" 
                                            DataValueField="id"  Width="178px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server" id="trtrgma">
                        <td>
                            <table id="Table1"  width="700px" dir="<%$Resources:Master, dir%>" runat="server" 
                                align="<%$Resources:Master, align%>">
                                <tr>
                                    <td id="Td2" align="<%$Resources:Master, align%>" runat="server">
                                        <asp:Label ID="Label41" runat="server" Text="<%$Resources:Master,txt_moalf%>"></asp:Label>
                                    </td>
                                    <td valign="top" align="<%$Resources:Master, align%>">
                                        <asp:TextBox ID="txt_enmoalf" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                               
                            </table>
                        </td>
                    </tr>
                     <tr>
                                    <td colspan="2" align="center">
                                        <asp:Button ID="btn_moalf_ar" runat="server" OnClick="btn_moalf_ar_Click" 
                                            Text="إضافة" />
                                    </td>
                      </tr>
                    
                    <tr id="tr_grid" runat="server">
                        <td>
                            <table id="Table2" align="<%$Resources:Master, align%>" width="700px" dir="<%$Resources:Master, dir%>" runat="server"
                                >
                                <tr id="Tr2" align="<%$Resources:Master, align%>" runat="server">
                                    <td  align="<%$Resources:Master, align%>" runat="server">
                                        <asp:GridView runat="server" ID="gview_moalf" Visible="false" AutoGenerateColumns="False"
                                            Width="500px" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                                            <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                            <Columns>
                                             <asp:TemplateField HeaderText="م">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbl_index" runat="server" Text='<%#((GridViewRow)Container).RowIndex + 1%>'></asp:Label>
                                                    
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                                    BorderWidth="1px"></HeaderStyle>
                                                <ItemStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                                    BorderWidth="1px"></ItemStyle>
                                            </asp:TemplateField>
                                       
                                                <asp:BoundField DataField="name" ShowHeader="true" HeaderText="اسم المؤلف" ItemStyle-HorizontalAlign="Center"
                                                    ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                    HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                    HeaderStyle-HorizontalAlign="Center" />
                                                <%-- <asp:BoundField DataField="title" ShowHeader="true" HeaderText="اسم المقالة" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" />--%>
                                         <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>" ItemStyle-HorizontalAlign="Center"
                                                    ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                    HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                    HeaderStyle-HorizontalAlign="Center" />
                                                    
                                                     <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" />
                                     <asp:BoundField DataField="author_type" ShowHeader="true" HeaderText="نوع المؤلف"
                                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                    ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                                    HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                                                <asp:BoundField DataField="author_role" ShowHeader="true" HeaderText="دور المؤلف"
                                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                    ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                                    HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                                                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="2%">
                                                    <ItemTemplate>
                                                        <asp:Button ID="btn_translate" CommandArgument='<%# Eval("author_id") %>' CommandName="TranslateItem"
                                                            runat="server" Text="ترجمة" OnClick="btn_translate_Click"   />
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                                                    </HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                                        BorderWidth="1px"></ItemStyle>
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imgDelete" CommandName="DeleteItem" CommandArgument='<%# Eval("id") %>'
                                                            OnClick="imgDelete_Click" CausesValidation="false" runat="server" ImageUrl="~/images/delete.gif"
                                                            OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;">
                                                        </asp:ImageButton>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                        BorderWidth="1px"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
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
                </ContentTemplate> 
            </asp:UpdatePanel>
        </td>
    </tr>
 </table> 