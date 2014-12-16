<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="objects_translate.aspx.cs" Inherits="administration_objects_translate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" cellpadding="5px" cellspacing="5px" dir="rtl">
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="Label2" runat="server" Text="ترجمة العناصر الأساسية" Font-Bold="True" ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 35%;">
                <asp:Label ID="Label1" runat="server" Text="النوع" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 65%;">
                <asp:DropDownList ID="types_list" runat="server" Width="300px" DataTextField="title"
                    DataValueField="id" Enabled="False">
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td align="right" style="width: 35%;">
                <asp:Label ID="Label3" runat="server" Text="اسم العنصر باللغة العربية" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 65%;">
                <asp:TextBox ID="arabic_name" Enabled="false" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 35%;">
                <asp:Label ID="Label4" runat="server" Text="اسم العنصر باللغة الانجليزية" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 65%;">
                <asp:TextBox ID="english_name" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 35%;">
                <asp:Label ID="Label5" runat="server" Text="اسم العنصر باللغة الفرنسية" Font-Bold="True"></asp:Label>
            </td>
            <td align="right" style="width: 65%;">
                <asp:TextBox ID="french_name" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="add_btn" runat="server" Text="حفظ" OnClick="add_btn_Click" OnClientClick="return check_value(1);" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="cancel_btn" runat="server" Text="عودة" OnClick="cancel_btn_Click" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lbl_result" Font-Bold="true" ForeColor="Green" Visible="false" runat="server" Text="تم الحفظ بنجاح"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
