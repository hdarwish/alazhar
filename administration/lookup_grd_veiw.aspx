<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="lookup_grd_veiw.aspx.cs" Inherits="administration_lookup_grd_veiw"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" align="center">
        <tr>
            <td height="60px">
                <asp:Label ID="lblcodeName" runat="server" Font-Bold="True" Font-Size="18px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:LinkButton ID="LinkButton1" runat="server" Text="صفحة الاكواد" PostBackUrl="~/administration/lookups_main_page.aspx"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="center" dir="rtl" height="60px">
                <asp:LinkButton ID="lbtnAdd" runat="server" Text="إضافة" ></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td dir="rtl" colspan="2" align="center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BorderColor="Black"
                    BorderStyle="Solid" BorderWidth="1px" Width="100%" OnPreRender="grdveiw1_onpreRender"
                    OnRowCommand="GridView1_RowCommand" AllowPaging="True"  OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="30">
                    <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <%-- <asp:TemplateField HeaderText="الكود">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                        <asp:BoundField HeaderText="العنصر" DataField="type1" HeaderStyle-Width="100px" ItemStyle-HorizontalAlign="Center"
                            ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                            HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                            HeaderStyle-HorizontalAlign="Center" Visible="False">
                            <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                Width="100px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                            </ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="العنصر المرتبط به" DataField="type2" HeaderStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                            ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                            HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" Visible="False">
                            <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                Width="100px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                            </ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="العنوان بالعربى" DataField="title_ar" HeaderStyle-Width="150px"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                            ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                            HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                Width="150px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                            </ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="العنوان بالانجليزية" DataField="title_en" HeaderStyle-Width="150px"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                            ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                            HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                Width="150px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                            </ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField HeaderText="العنوان بالفرنسية" DataField="title_fr" HeaderStyle-Width="150px"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                            ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                            HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"
                                Width="150px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                            </ItemStyle>
                        </asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" Text="تعديل" PostBackUrl='<%# "~/administration/lookup_add_edit.aspx?table_id="+ Eval("id") %>'></asp:LinkButton>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                BorderWidth="1px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                BorderWidth="1px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" Text="حذف" CommandArgument='<%#Eval("id")%>'>
                                </asp:LinkButton>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                BorderWidth="1px"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid"
                                BorderWidth="1px"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
