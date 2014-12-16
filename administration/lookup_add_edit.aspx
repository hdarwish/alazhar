<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="lookup_add_edit.aspx.cs" Inherits="administration_lookup_add_edit" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 25%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" dir="rtl">
<tr>
    <td colspan="2" height="60px" width="100%">
        
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="18px" Text="تعديل / إضافة "></asp:Label>
        
    </td>
</tr>
<tr id="ddls" runat="server" visible="false">
    <td height="60px" class="style1" > 
       <asp:DropDownList ID="ddlMain" runat="server" Width="100%" ></asp:DropDownList>
    </td>
    <td align="center">
         <asp:DropDownList ID="ddlsub" runat="server" Width="95%" ></asp:DropDownList>
      
    </td>
</tr>
<tr>
    <td class="style1"> 
        <asp:Label ID="Label2" runat="server" Text="العنوان بالعربية"></asp:Label>
        
    </td>
    <td align="right">
        <asp:TextBox ID="txtArabicTitle" runat="server" Width="75%"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtArabicTitle"
                    ErrorMessage="Only characters allowed" ValidationExpression="[^0-9]+" ValidationGroup="group45"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td class="style1"> 
        <asp:Label ID="Label3" runat="server" Text="العنوان بالانجليزية"></asp:Label>
    </td>
    <td align="right">
        <asp:TextBox ID="txtEngilshTitle" runat="server" Width="75%"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEngilshTitle"
                    ErrorMessage="Only characters allowed" ValidationExpression="[^0-9]+" ValidationGroup="group45"></asp:RegularExpressionValidator>
  
    </td>
</tr>
<tr>
    <td class="style1" > 
        <asp:Label ID="Label4" runat="server" Text="العنوان بالفرنسية"></asp:Label>
    </td>
    <td width="75%" align="right">
        <asp:TextBox ID="txtFrenshTitle" runat="server" Width="75%" ></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtFrenshTitle"
                    ErrorMessage="Only characters allowed" ValidationExpression="[^0-9]+" ValidationGroup="group45"></asp:RegularExpressionValidator>
  
 
    </td>
</tr>
<tr>
   
    <td width="75%" align="center" colspan="2" height="60px" >
        <asp:Button ID="btnSave" runat="server" Text="حفظ" onclick="btnSave_Click" ValidationGroup="group45" />
    </td>
</tr>
<tr>
     <td align="center" colspan="2">
            <asp:LinkButton ID="LinkButton1" runat="server" Text="صفحة الاكواد" 
                PostBackUrl="~/administration/lookups_main_page.aspx"></asp:LinkButton>
        </td>
    </tr>
</table>
</asp:Content>

