<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="objects_titles_replace.aspx.cs" Inherits="administration_objects_titles_replace" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" cellpadding="5px" cellspacing="5px" dir="rtl">
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="Label2" runat="server" Text="العناصر الرئيسية" Font-Bold="True" ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" style="">
                <asp:Label ID="Label1" runat="server" Text="الإستمارة" Font-Bold="True"></asp:Label>
            </td>
            <td align="right">
                <%--<asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>--%>
                <asp:DropDownList ID="types_list" runat="server" Width="200px" DataTextField="title"
                    DataValueField="id" AutoPostBack="true" 
                    OnSelectedIndexChanged="types_list_SelectedIndexChanged">
                </asp:DropDownList>
                <%--</ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label3" runat="server" Text="  العنصر الرئيسى :" 
                    Font-Bold="True"></asp:Label>
            </td>
            <td align="right">
                
               <%-- <asp:DropDownList ID="ddl_object_name" runat="server" Width="430px" AutoPostBack="true"
                    OnSelectedIndexChanged="object_name_SelectedIndexChanged"></asp:DropDownList>--%>
                    
                    <uc7:Smart_Search ID="Smrt_Srch_object_name" runat="server" Visible="true" />
            </td>
        </tr>
        
        <tr>
            <td align="right">
                <asp:Label ID="Label4" runat="server" Text="  المستبدل :" 
                    Font-Bold="True"></asp:Label>
            </td>
            <td align="right">
               <%-- <asp:DropDownList ID="ddl_replace_name" runat="server" Width="430px" 
                    ></asp:DropDownList>--%>
                     <uc7:Smart_Search ID="Smrt_Srch_object_replace_name" runat="server" Visible="true" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                
                <asp:Button ID="replace_btn" runat="server" Text="إستبدال"  OnClick="replace_btn_Click" />
              
            </td>
        </tr>
       <%-- <tr>
            <td align="right" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="" Font-Bold="True"></asp:Label>
            </td>
        </tr>--%>
        <%--<tr>
            <td colspan="2" align="center">
                <asp:HiddenField ID="translate_en" runat="server" />
                <asp:HiddenField ID="translate_fr" runat="server" />
                <asp:GridView ID="objects_grid" runat="server" CellPadding="4" ForeColor="#333333"
                    GridLines="None" Width="98%" OnRowCommand="objects_grid_RowCommand" AutoGenerateColumns="False"
                     AllowPaging="True"  OnPageIndexChanging="objects_grid_PageIndexChanging" PageSize="20" OnRowDataBound="objects_grid_RowDataBound">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F6F2E2" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" Visible="False" />
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الاسم" ItemStyle-Width="32%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <input id="user_id" runat="server" type="hidden" value='<%# Eval("id") %>' />
                                <asp:Label ID="title_lbl" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="32%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الباحث" ItemStyle-Width="32%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="assigned_lbl" runat="server" Text='<%# Eval("assigned") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="32%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الكود" ItemStyle-Width="2%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="assigned_lbl2" runat="server" dir="ltr" Text='<%# Eval("code") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="2%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="مترجم EN" ItemStyle-Width="2%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="translated_EN" runat="server" dir="rtl" Text="-"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="2%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="مترجم FR" ItemStyle-Width="2%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="translated_FR" runat="server" dir="rtl" Text="-"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="2%"></ItemStyle>
                        </asp:TemplateField>
                        <%--<asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="2%">
                            <ItemTemplate>
                                <asp:Button ID="btn_replace" CommandArgument='<%# Eval("id") %>' CommandName="replace"
                                    runat="server" Text="استبدال" OnClientClick="return check_value(2);" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="4%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="2%">
                            <ItemTemplate>
                                <asp:Button ID="btn_translate" CommandArgument='<%# Eval("id") %>' CommandName="translate"
                                    runat="server" Text="ترجمة" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="4%"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>--%>
        <tr>
            <td align="center" colspan="2">
                
                <asp:Button ID="cancel_btn" runat="server" Text="الصفحة الرئيسية" OnClick="cancel_btn_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
