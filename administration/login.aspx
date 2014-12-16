<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="login.aspx.cs" Inherits="administration_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <table width="50%" dir="rtl" border="0" cellpadding="5" cellspacing="5">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label4" runat="server" Text="تسجيل الدخول" Font-Bold="True" ForeColor="#996633"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" nowrap>
                    <asp:Label ID="Label1" runat="server" Text="اسم المستخدم"></asp:Label>
                </td>
                <td align="right">
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" nowrap>
                    <asp:Label ID="Label2" runat="server" Text="كلمة المرور"></asp:Label>
                </td>
                <td align="right">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="save" runat="server" OnClick="Button1_Click" Text="دخول" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    </center>
</asp:Content>
