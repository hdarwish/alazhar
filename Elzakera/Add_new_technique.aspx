<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="Add_new_technique.aspx.cs" Inherits="Elzakera_Add_new_technique" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style15
        {
            width: 96%;
        }
        .style16
        {
            height: 25px;
            width: 337px;
        }
        .style17
        {
            height: 23px;
            width: 337px;
        }
        .style18
        {
            height: 23px;
            width: 204px;
        }
        .style19
        {
            height: 25px;
            width: 204px;
        }
        .style20
        {
            width: 204px;
        }
        .style21
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="left" class="style15">
        <tr>
            <td align="left" class="style18">
                &nbsp;</td>
            <td align="left" class="style17">
                <asp:TextBox ID="idtxt" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" class="style18">
                <asp:Label ID="Label1" runat="server" Text="اسم التقنية باللغة العربية"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="tech_ar" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td align="left" class="style17">
                <asp:TextBox ID="tech_ar" runat="server" Height="20px" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" class="style19">
                <asp:Label ID="Label2" runat="server" Text="Techniques Name by English"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="tech_en" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td align="left" class="style16">
                <asp:TextBox ID="tech_en" runat="server" Height="20px" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr align="left">
            <td class="style20">
                <asp:Label ID="Label3" runat="server" Text="Nom Techniques par francia"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="tech_fre" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="style21">
                <asp:TextBox ID="tech_fre" runat="server" Height="20px" Width="226px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20">
                &nbsp;</td>
            <td align="justify" class="style21">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Save" Width="69px" Height="26px" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Clear" />
                <asp:Button ID="Button3" runat="server" Text="Cancel" />
            </td>
        </tr>
        </table>
</asp:Content>

