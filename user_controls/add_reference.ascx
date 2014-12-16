<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_reference.ascx.cs"
    Inherits="user_controls_add_reference" %>
<table style="width: 700px" border="0" cellspacing="5" dir="rtl">
    <asp:HiddenField ID="content_id" runat="server" Value="" />
    <asp:HiddenField ID="content_type" runat="server" Value="" />
    <tr visible="true" runat="server" id="tr_ref">
        <td align="right">
            <table width="600px">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblerror" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="النوع"></asp:Label>
                    </td>
                    <td dir="rtl" align="right">
                        <asp:DropDownList ID="drop_type" runat="server" DataTextField="title" DataValueField="id"
                            AutoPostBack="true" OnSelectedIndexChanged="drop_type_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label9" runat="server" Text="العنوان:"></asp:Label>
                    </td>
                    <td dir="rtl" align="right">
                        <asp:TextBox ID="txt_ref" runat="server" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr align="right">
                    <td align="right">
                        <asp:Label ID="Label10" runat="server" Text=" ملاحظات"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_notes" runat="server" Height="47px" TextMode="MultiLine" Width="355px"></asp:TextBox>
                    </td>
                    <%-- <td>
            <asp:CheckBox ID="CheckBox1" runat="server" /></td>--%>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Btn_ref" runat="server" OnClick="Btn_ref_Click" Text="إضافة" 
                            ValidationGroup="add_ref" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table width="700px">
                <tr align="right">
                    <td colspan="2" align="right">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="700px"
                            CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="true" 
                            PageSize="10" DataKeyNames="id"
                            OnRowCommand="GridView1_RowCommand" 
                            OnRowDataBound="GridView1_RowDataBound" 
                            onpageindexchanging="GridView1_PageIndexChanging">
                            <FooterStyle BackColor="" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"
                                Height="2px" />
                            <RowStyle BackColor="" />
                            <Columns>
                                <asp:TemplateField HeaderText="نوع العنصر" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="type" runat="server" Text=""></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        Width="30px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        Width="30px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:BoundField DataField="title" HeaderText="اسم المرجع" SortExpression="title"
                                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                    ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                    HeaderStyle-BorderWidth="1px" ItemStyle-Width="40px" HeaderStyle-Width="40px"
                                    HeaderStyle-HorizontalAlign="Center" />
                                <asp:TemplateField HeaderText="ملاحظات" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="notes" runat="server" Text='<%# Eval("notes") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="120px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="120px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></ItemStyle>
                                </asp:TemplateField>
                                <%--<asp:BoundField DataField="moalaf_type" HeaderText=" النوع" ItemStyle-HorizontalAlign="Center"
                        SortExpression="type" />--%>
                                <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgDelete" CommandName="DeleteItem" CommandArgument='<%# Eval("id") %>'
                                            OnClick="imgDelete_Click" runat="server" ImageUrl="~/images/delete.gif" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;">
                                        </asp:ImageButton>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="20px" BorderColor="Black" BorderStyle="Solid"
                                        BorderWidth="1px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="20px" BorderColor="Black" BorderStyle="Solid"
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
