<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="objects_titles.aspx.cs" Inherits="administration_objects_titles" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

  <script type="text/javascript">
      function check_value(flag) {
          
          var ctrID = document.getElementById("<%=object_name.ClientID %>").value;
          if (ctrID == '') {
              alert('من فضلك أدخل اسم العنصر');
              return false;
          }
          else {
              if (flag == 2) {
                  if (confirm('سوف يتم استبدال اسم العنصر بالاسم الجديد,موافق؟'))
                      return true;
                  else
                      return false;
              }
              else
                  return true;
          }
      }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" cellpadding="5px" cellspacing="5px" dir="rtl">
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="Label2" runat="server" Text="العناصر الرئيسية" Font-Bold="True" ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 15%;">
                <asp:Label ID="Label1" runat="server" Text="النوع" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 85%;">
                <%--<asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>--%>
                <asp:DropDownList ID="types_list" runat="server" Width="300px" DataTextField="title"
                    DataValueField="id" AutoPostBack="true" OnSelectedIndexChanged="types_list_SelectedIndexChanged">
                </asp:DropDownList>
                <%--</ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 15%;">
                <asp:Label ID="Label3" runat="server" Text="كود/إسم العنصر" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 85%;">
             <asp:TextBox ID="object_Id" runat="server" Width="50px" ></asp:TextBox>
               <asp:TextBox ID="object_name" runat="server" Width="500px"></asp:TextBox>
                <%-- <uc7:Smart_Search ID="Smrt_Srch_object_name" runat="server" Visible="true" />--%>
                <cc1:FilteredTextBoxExtender ID="TextBoxExtender1" runat="server" TargetControlID="object_Id"
                        FilterType="Numbers" />
            </td>
        </tr>
        <tr runat="server" id="extra_field1_tr" visible="false">
            <td align="right" style="width: 15%;">
                <asp:Label ID="key_field1" runat="server" Text="" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 85%;">
                <table width="100%">
                    <tr id="moalef1_tr" runat="server" visible="false">
                        <td>
                            من الشخصيات
                        </td>
                        <td>
                            من المؤلفين
                        </td>
                    </tr>
                    <tr id="moalef2_tr" runat="server" visible="false">
                        <td>
                            <asp:DropDownList ID="char_lst" runat="server" DataTextField="name" DataValueField="char_id"
                            Width="500px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="auth_lst" runat="server" DataTextField="name" DataValueField="author_id">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:TextBox ID="extra_field1" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr runat="server" id="extra_field2_tr" visible="false">
            <td align="right" style="width: 15%;">
                <asp:Label ID="key_field2" runat="server" Text="" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 85%;">
                <asp:TextBox ID="extra_field2" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="agree_btn" runat="server" Text="بحث" OnClick="agree_btn_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="add_btn" runat="server" Text="إضافة" OnClick="add_btn_Click" OnClientClick="return check_value(1);" />
                
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:HiddenField ID="translate_en" runat="server" />
                <asp:HiddenField ID="translate_fr" runat="server" />
                <asp:GridView ID="objects_grid" runat="server" CellPadding="4" ForeColor="#333333"
                    GridLines="None" Width="100%" OnRowCommand="objects_grid_RowCommand" AutoGenerateColumns="False"
                     AllowPaging="True"  OnPageIndexChanging="objects_grid_PageIndexChanging" PageSize="20" OnRowDataBound="objects_grid_RowDataBound">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F6F2E2" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True"
                            SortExpression="id" Visible="False" />
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الاسم" ItemStyle-Width="300px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <input id="user_id" runat="server" type="hidden" value='<%# Eval("id") %>' />
                                <asp:Label ID="title_lbl" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="300px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="المؤلف" ItemStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center" Visible="true" >
                            <ItemTemplate>
                               
                                <asp:Label ID="title_authername" runat="server" Text='<%# Eval("authername") %>' ></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="100px"></ItemStyle>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="تاريخ النشر" ItemStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center" Visible="true" >
                            <ItemTemplate>
                                
                                <asp:Label ID="title_pup_date" runat="server" Text='<%# Eval("pup_date") %>' ></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="100px"></ItemStyle>
                        </asp:TemplateField>
                       
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الباحث" ItemStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="assigned_lbl" runat="server" Text='<%# Eval("assigned") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="100px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="الكود" ItemStyle-Width="75px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="assigned_lbl2" runat="server" dir="ltr" Text='<%# Eval("code") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="75px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="مترجم EN" ItemStyle-Width="20px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="translated_EN" runat="server" dir="rtl" Text="-"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="20px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderText="مترجم FR" ItemStyle-Width="20px"
                            ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="translated_FR" runat="server" dir="rtl" Text="-"></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true"></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center"  Width="20px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="30px">
                            <ItemTemplate>
                                <asp:Button ID="btn_replace" CommandArgument='<%# Eval("id") %>' CommandName="replace"
                                    runat="server" Text="استبدال" OnClientClick="return check_value(2);" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="30px">
                            <ItemTemplate>
                                <asp:Button ID="btn_translate" CommandArgument='<%# Eval("id") %>' CommandName="translate"
                                    runat="server" Text="ترجمة" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" ></HeaderStyle>
                            <ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
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
            <td align="center" colspan="2">
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="cancel_btn" runat="server" Text="الصفحة الرئيسية" OnClick="cancel_btn_Click" />
            </td>
        </tr>
    </table>
      
</asp:Content>
