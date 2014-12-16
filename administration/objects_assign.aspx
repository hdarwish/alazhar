<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="objects_assign.aspx.cs" Inherits="administration_objects_assign" Title="" %>

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
            <td align="right" style="width: 25%;">
                <asp:Label ID="Label1" runat="server" Text="النوع" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 75%;">
                <asp:DropDownList ID="types_list" runat="server" Width="300px" DataTextField="title"
                    DataValueField="id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 25%;">
                <asp:Label ID="Label3" runat="server" Text="الإسم" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 75%;">
                <asp:TextBox ID="object_name" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:RadioButtonList ID="RadioBtt_researsh" runat="server" Height="28px" Width="529px"
                    RepeatDirection="Horizontal" Style="margin-top: 0px; margin-left: 2px; margin-right: 0px;">
                    <asp:ListItem Selected="True" Value="0">اختيار الكل</asp:ListItem>
                    <asp:ListItem Value="1">العناصر المسندة لباحث </asp:ListItem>
                    <asp:ListItem Value="2">العناصر الغير مسندة لباحث</asp:ListItem>
                   
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="agree_btn" runat="server" Text="عرض" OnClick="agree_btn_Click" />
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="متشابهات" Font-Bold="True" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:GridView ID="objects_grid" runat="server" Width="99%" AutoGenerateColumns="False"
                     AllowPaging="True"  OnPageIndexChanging="objects_grid_PageIndexChanging" PageSize="20">
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
                            <ItemStyle HorizontalAlign="Center" Width="32%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="معلومات إضافية"
                            ItemStyle-Width="32%" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="add_info_lbl" runat="server" Text='<%# Eval("add_info") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="32%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الباحث" ItemStyle-Width="32%"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="assigned_lbl" runat="server" Text='<%# Eval("assigned") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="32%"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="4%">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkSelectAll" runat="server" AutoPostBack="true" OnCheckedChanged="chkSelectAll_CheckedChanged" />
                                <asp:Label ID="selAll" Text="اختيار الكل" runat="server"></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="ActivateEn" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Wrap="false"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Wrap="false" Width="10%"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 25%;">
                <asp:Label ID="Label5" runat="server" Text="الباحث" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 75%;">
                <asp:DropDownList ID="researcher" runat="server" Width="300px" DataTextField="name"
                    DataValueField="id">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="add_btn" runat="server" Text="اسناد" OnClick="add_btn_Click" />
                &nbsp;&nbsp;<asp:Button ID="cancel_btn" runat="server" Height="27px" OnClick="cancel_btn_Click"
                    Text="الغاء الإسناد" />
                &nbsp; &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
